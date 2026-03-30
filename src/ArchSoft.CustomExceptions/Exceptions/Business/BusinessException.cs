using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Business;

[ExcludeFromCodeCoverage]
public class BusinessException : UnprocessableEntityException
{
    public BusinessException()
    {
    }

    public BusinessException(string message) : base(message)
    {
    }

    public BusinessException(string message, Exception inner) : base(message, inner)
    {
    }
}

