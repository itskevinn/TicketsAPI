using System.Data;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace Infrastructure.Persistence.Factory;

public class ConnectionFactory : IConnectionFactory
{
    private readonly IDbConnection? _connection;

    public ConnectionFactory(IConfiguration config)
    {
        _connection =
            new OracleConnection(config.GetConnectionString("local"));
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