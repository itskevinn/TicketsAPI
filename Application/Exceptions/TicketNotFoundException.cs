using System.Runtime.Serialization;

namespace Application.Exceptions;

/// <summary>
/// Exception thrown when ticket is not found in the database
/// </summary>
[Serializable]
public class TicketNotFoundException : Exception
{
    public TicketNotFoundException()
    {
    }

    protected TicketNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public TicketNotFoundException(string? message) : base(message)
    {
    }

    public TicketNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}