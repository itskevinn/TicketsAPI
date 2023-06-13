FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TicketsGateway.Api/TicketsGateway.Api.csproj", "TicketsGateway.Api/"]
RUN dotnet restore "TicketsGateway.Api/TicketsGateway.Api.csproj"
COPY . .
WORKDIR "/src/TicketsGateway.Api"
RUN dotnet build "TicketsGateway.Api.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "TicketsGateway.Api.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TicketsGateway.Api.dll"]
