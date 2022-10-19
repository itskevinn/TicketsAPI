using System.Data;
using System.Data.Common;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Persistence.Factory;

public class ConnectionFactory : IConnectionFactory
{
    private readonly string? _connectionString;

    public ConnectionFactory(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public IDbConnection? Connection
    {
        get
        {
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            var conn = factory.CreateConnection();
            if (conn == null) return null;
            conn.ConnectionString = _connectionString;
            conn.Open();
            return conn;
        }
    }
}