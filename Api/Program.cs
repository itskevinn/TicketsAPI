using System.Reflection;
using System.Text;
using Application.Security.Http.Dto;
using Infrastructure.Core.Helpers;
using Infrastructure.Persistence.Context;
using Infrastructure.Security.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using TicketsWebServices.Extensions;
using TicketsWebServices.Filters;

var builder = WebApplication.CreateBuilder(args);
const string myAllowSpecificOrigins = "_myAllowSpecificOrigins";
var config = builder.Configuration;

builder.Services.AddControllers(opts => { opts.Filters.Add(typeof(AppExceptionFilterAttribute)); });

builder.Services.AddEndpointsApiExplorer().AddMappings();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
        corsPolicyBuilder => { corsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); });
});
builder.Services.AddSwaggerGen(c =>
{
    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "JWT Authentication",
        Description = "Enter JWT Bearer token **_only_**",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme,
        }
    };
    c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { securityScheme, new string[] { } }
    });
});
builder.Services.AddAutoMapper(Assembly.Load("Application"));
builder.Services.AddDbContext<TicketsContext>(opt =>
{
    opt.UseSqlServer(config.GetConnectionString("local"),
        sqlOpts =>
        {
            sqlOpts.MigrationsHistoryTable("_MigrationHistory",
                config.GetValue<string>("SchemaName"));
        });
});

builder.Services.AddHealthChecks().AddSqlServer(config["ConnectionStrings:local"]);

builder.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

builder.Services.AddPersistence(config).AddServices().AddScopedServices();
builder.Services.AddScoped(typeof(IJwtUtils<>), typeof(JwtUtils<>));
builder.Services.AddAuthorization();

var appSettingsSection = config.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettingsSection);
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var appSettings = appSettingsSection.Get<AppSettings>();
var key = Encoding.ASCII.GetBytes(appSettings.Secret);
builder.Services.AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
builder.Services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tickets Api", Version = "v1" }); });
builder.Services.Configure<AppSettings>(builder.Configuration);

Log.Logger = new LoggerConfiguration().Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File($"AppLogs/Api-{DateTime.Now.Millisecond}.log", rollingInterval: RollingInterval.Day)
    .CreateLogger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ticket Api"));
}

app.UseMiddleware<JwtMiddleware<UserDto>>();
app.UseCors(myAllowSpecificOrigins);
app.UseRouting();
app.UseHttpLogging();
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();
app.Run();