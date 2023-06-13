using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Persistence.Factory;

public class ConnectionFactory : IConnectionFactory
{
    private readonly IDbConnection? _connection;

    public ConnectionFactory(IConfiguration config)
    {
        _connection =
            new SqlConnection(config.GetConnectionString("local"));
    }

    public IDbConnection? Connection
    {
        get
        {
            if (_connection == null) return null;
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            return _connection;
        }
    }
}