using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Auth;

[ExcludeFromCodeCoverage]
public class AuthorizationException : UnauthorizedException
{
    public AuthorizationException()
    {
    }

    public AuthorizationException(string message) : base(message)
    {
    }

    public AuthorizationException(string message, Exception inner) : base(message, inner)
    {
    }
}

