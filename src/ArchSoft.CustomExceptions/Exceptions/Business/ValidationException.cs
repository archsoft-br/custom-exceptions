using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Business;

[ExcludeFromCodeCoverage]
public class ValidationException : UnprocessableEntityException
{
    public ValidationException()
    {
    }

    public ValidationException(string message) : base(message)
    {
    }

    public ValidationException(string message, Exception inner) : base(message, inner)
    {
    }
}

