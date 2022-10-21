using System.Runtime.Serialization;

namespace Infrastructure.Persistence.Exceptions;

[Serializable]
public class DatabaseUnavailableException : Exception
{
    public DatabaseUnavailableException()
    {
    }

    public DatabaseUnavailableException(string message) : base(message)
    {
    }

    public DatabaseUnavailableException(string message, Exception inner) : base(message, inner)
    {
    }

    protected DatabaseUnavailableException(
        SerializationInfo info,
        StreamingContext context) : base(info, context)
    {
    }
}