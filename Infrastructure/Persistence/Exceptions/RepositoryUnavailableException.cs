using System.Runtime.Serialization;

namespace Infrastructure.Persistence.Exceptions;

[Serializable]
public class RepositoryUnavailableException : Exception
{
    public RepositoryUnavailableException()
    {
    }

    public RepositoryUnavailableException(string message) : base(message)
    {
    }

    public RepositoryUnavailableException(string message, Exception inner) : base(message, inner)
    {
    }

    protected RepositoryUnavailableException(
        SerializationInfo info,
        StreamingContext context) : base(info, context)
    {
    }
}