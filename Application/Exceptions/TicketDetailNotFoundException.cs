using System.Runtime.Serialization;

namespace Application.Exceptions;

/// <summary>
/// Exception thrown when ticket detail is not found in the database
/// </summary>
[Serializable]
public class TicketDetailNotFoundException : Exception
{
    public TicketDetailNotFoundException()
    {
    }

    protected TicketDetailNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public TicketDetailNotFoundException(string? message) : base(message)
    {
    }

    public TicketDetailNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}