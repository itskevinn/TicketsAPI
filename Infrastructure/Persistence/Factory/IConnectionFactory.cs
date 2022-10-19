using System.Data;

namespace Infrastructure.Persistence.Factory;

public interface IConnectionFactory
{
    public IDbConnection? Connection { get; }
}