using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.IO;

[ExcludeFromCodeCoverage]
public class InputException : BadRequestException
{
    public InputException()
    {
    }

    public InputException(string message) : base(message)
    {
    }

    public InputException(string message, Exception inner) : base(message, inner)
    {
    }
}

