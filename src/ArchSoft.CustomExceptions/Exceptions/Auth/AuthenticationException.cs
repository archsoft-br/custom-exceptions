using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Auth;

[ExcludeFromCodeCoverage]
public class AuthenticationException : ForbiddenException
{
    public AuthenticationException()
    {
    }

    public AuthenticationException(string message) : base(message)
    {
    }

    public AuthenticationException(string message, Exception inner) : base(message, inner)
    {
    }
}

