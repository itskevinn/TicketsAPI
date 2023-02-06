using System.Runtime.Serialization;

namespace Application.Exceptions;

/// <summary>
/// Exception thrown when ticket detail is not found in the database
/// </summary>
[Serializable]
public class TicketStatusNotFoundException : Exception
{
    public TicketStatusNotFoundException()
    {
    }

    protected TicketStatusNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public TicketStatusNotFoundException(string? message) : base(message)
    {
    }

    public TicketStatusNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}