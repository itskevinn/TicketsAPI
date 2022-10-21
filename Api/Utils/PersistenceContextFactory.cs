using Infrastructure.Core.Helpers;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TicketsWebServices.Utils;

public class PersistenceContextFactoryFactory : IDesignTimeDbContextFactory<TicketsContext>
{
	public TicketsContext CreateDbContext(string[] args)
	{
		var config = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json")
			.Build();

		var optionsBuilder = new DbContextOptionsBuilder<TicketsContext>();
		optionsBuilder.UseOracle(config.GetConnectionString("local"),
			sqlOpts => { sqlOpts.MigrationsHistoryTable("_MigrationHistory", config.GetValue<string>("SchemaName")); });

		return new TicketsContext(optionsBuilder.Options, new AppSettings());
	}
}