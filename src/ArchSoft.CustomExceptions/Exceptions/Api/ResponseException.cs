using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Api;

[ExcludeFromCodeCoverage]
public class ResponseException : InternalServerErrorException
{
    public ResponseException()
    {
    }

    public ResponseException(string message) : base(message)
    {
    }

    public ResponseException(string message, Exception inner) : base(message, inner)
    {
    }
}

