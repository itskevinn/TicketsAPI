using System.Data;
using Infrastructure.Persistence.Exceptions;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;

namespace Infrastructure.Persistence.Factory;

public class ConnectionFactory : IConnectionFactory
{
    private const string TnsName = "ORCL";
    private readonly ILogger<ConnectionFactory> _logger;
    private IDbConnection? _connection;

    public ConnectionFactory(ILogger<ConnectionFactory> logger)
    {
        SetupOracleConnection();
        _logger = logger;
    }

    public IDbConnection Connection =>
        _connection ?? throw new DatabaseUnavailableException("database connection is unavailable");

    private void SetupOracleConnection()
    {
        if (_connection != null) return;
        OracleConfiguration.OracleDataSources.Add(TnsName,
            "(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-FP8GDE4)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl)))");
        // Set default statement cache size to be used by all connections.
        OracleConfiguration.StatementCacheSize = 25;

        // Disable self tuning by default.
        OracleConfiguration.SelfTuning = false;

        // Bind all parameters by name.
        OracleConfiguration.BindByName = true;

        // Set default timeout to 60 seconds.
        OracleConfiguration.CommandTimeout = 60;

        // Set default fetch size as 1 MB.
        OracleConfiguration.FetchSize = 1024 * 1024;

        // Set tracing options
        OracleConfiguration.TraceOption = 1;
        OracleConfiguration.TraceFileLocation = @"C:\Users\WINDOWS\Documents\DEV\TicketsApp\DBTracing";
        // Uncomment below to generate trace files
        OracleConfiguration.TraceLevel = 7;

        // Set network properties
        OracleConfiguration.SendBufferSize = 8192;
        OracleConfiguration.DisableOOB = true;
        OracleConnection oracleConnection = null!;
        try
        {
            oracleConnection = new OracleConnection($"user id=kevinadmin; password=1234; data source={TnsName}");
            oracleConnection.Open();
            _connection = oracleConnection;
        }
        catch (Exception e)
        {
            _logger.LogError("An error occurred while trying to connect to database {EMessage}", e.Message);
        }
        finally
        {
            oracleConnection.Close();
        }
    }
}