using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Business;

[ExcludeFromCodeCoverage]
public class RuleException : UnprocessableEntityException
{
    public RuleException()
    {
    }

    public RuleException(string message) : base(message)
    {
    }

    public RuleException(string message, Exception inner) : base(message, inner)
    {
    }
}

