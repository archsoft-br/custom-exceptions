# ArchSoft.CustomExceptions

[![NuGet](https://img.shields.io/nuget/v/ArchSoft.CustomExceptions.svg)](https://www.nuget.org/packages/ArchSoft.CustomExceptions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-8.0%20%7C%209.0-blue.svg)](https://dotnet.microsoft.com)

**English** | [Português (Brasil)](README.pt-BR.md)

A comprehensive collection of **domain-specific custom exceptions** for .NET applications. This library extends [ArchSoft.Http.Exceptions](https://github.com/archsoft-br/http-exceptions) to provide typed exceptions for common scenarios like business rules, resource management, security, and more.

---

## Installation

```bash
dotnet add package ArchSoft.CustomExceptions
```

## Features

- **Domain-specific exceptions** – Business, Resource, Security, Concurrency, and more
- **Built on HTTP exceptions** – Extends `ArchSoft.Http.Exceptions` for seamless API integration
- **Factory pattern support** – Use `HttpExceptionFactory` and `HttpStatusCodeFactory` from the base library
- **Clean architecture friendly** – Separate domain errors from transport-layer concerns

## Exception Categories

### Api

Exceptions for API communication failures.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `RequestException` | `BadRequestException` | 400 | Invalid API request formatting or parameters |
| `ResponseException` | `InternalServerErrorException` | 500 | Invalid or unexpected API response |

### Auth

Authentication and authorization exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `AuthenticationException` | `ForbiddenException` | 403 | Authentication failure (invalid credentials) |
| `AuthorizationException` | `UnauthorizedException` | 401 | Authorization failure (insufficient permissions) |

### Broker

Message broker exceptions (Kafka, RabbitMQ, etc.).

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `BrokerException` | `BadGatewayException` | 502 | General broker communication error |
| `ConsumerException` | `BadGatewayException` | 502 | Message consumption failure |
| `ProducerException` | `BadGatewayException` | 502 | Message publishing failure |

### Business

Business rule validation exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `BusinessException` | `UnprocessableEntityException` | 422 | Generic business rule violation |
| `RuleException` | `UnprocessableEntityException` | 422 | Specific business rule violation |
| `ValidationException` | `UnprocessableEntityException` | 422 | Input validation failure |

### Concurrency

Concurrency control exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `ConcurrencyException` | `ConflictException` | 409 | Concurrent modification detected |
| `VersionMismatchException` | `ConflictException` | 409 | Optimistic locking version conflict |

### Configuration

Configuration-related exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `ConfigurationException` | `InternalServerErrorException` | 500 | Missing or invalid configuration value |

### Integration

External service integration exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `IntegrationException` | `BadGatewayException` | 502 | External service integration failure |

### IO

Input/Output operation exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `InputException` | `BadRequestException` | 400 | Input reading or parsing error |
| `OutputException` | `InternalServerErrorException` | 500 | Output writing error |

### Operation

General operation exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `OperationException` | `ConflictException` | 409 | Generic operation failure |

### Process

Data processing exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `ProcessException` | `UnprocessableEntityException` | 422 | General processing error |
| `MapException` | `UnprocessableEntityException` | 422 | Object mapping failure |
| `ParseException` | `UnprocessableEntityException` | 422 | Data parsing failure |

### Resource

Resource management exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `ResourceNotFoundException` | `NotFoundException` | 404 | Resource does not exist |
| `ResourceAlreadyExistsException` | `ConflictException` | 409 | Duplicate resource creation attempt |
| `ResourceExhaustedException` | `TooManyRequestsException` | 429 | Resource quota or capacity exceeded |

### Resilience

Resilience pattern exceptions (circuit breaker, rate limiting, etc.).

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `RateLimitExceededException` | `TooManyRequestsException` | 429 | Rate limit quota exceeded |
| `ThrottlingException` | `TooManyRequestsException` | 429 | Request throttling applied |
| `IdempotencyException` | `ConflictException` | 409 | Idempotency key conflict |

### Security

Security-related exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `EncryptionException` | `InternalServerErrorException` | 500 | Data encryption failure |
| `DecryptionException` | `InternalServerErrorException` | 500 | Data decryption failure |
| `InvalidSignatureException` | `ForbiddenException` | 403 | Cryptographic signature validation failure |

### Unavailable

Service availability exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `UnavailableException` | `ServiceUnavailableException` | 503 | Service temporarily unavailable |

### Unexpected

Unexpected error exceptions.

| Exception | Base HTTP Exception | HTTP Code | When to Use |
|-----------|---------------------|-----------|-------------|
| `UnexpectedException` | `InternalServerErrorException` | 500 | Unexpected/unhandled error |

---

## Usage Examples

### Basic Usage

```csharp
using ArchSoft.CustomExceptions.Exceptions.Resource;

public class UserService
{
    public User GetUser(Guid id)
    {
        var user = _repository.Find(id);

        if (user == null)
            throw new ResourceNotFoundException($"User with id {id} not found");

        return user;
    }
}
```

### Business Rule Validation

```csharp
using ArchSoft.CustomExceptions.Exceptions.Business;

public class OrderService
{
    public void PlaceOrder(OrderRequest request)
    {
        if (request.Items.Count == 0)
            throw new ValidationException("Order must contain at least one item");

        if (request.TotalAmount <= 0)
            throw new RuleException("Order total must be greater than zero");

        // Process order...
    }
}
```

### Concurrency Control

```csharp
using ArchSoft.CustomExceptions.Exceptions.Concurrency;

public class DocumentService
{
    public void UpdateDocument(Guid id, DocumentUpdate update, long expectedVersion)
    {
        var document = _repository.Get(id);

        if (document.Version != expectedVersion)
            throw new VersionMismatchException(
                $"Document version mismatch. Expected: {expectedVersion}, Actual: {document.Version}");

        // Update document...
    }
}
```

### Security Operations

```csharp
using ArchSoft.CustomExceptions.Exceptions.Security;

public class CryptoService
{
    public string Decrypt(string cipherText)
    {
        try
        {
            return _encryptionProvider.Decrypt(cipherText);
        }
        catch (CryptographicException ex)
        {
            throw new DecryptionException("Failed to decrypt data", ex);
        }
    }
}
```

## Using Factories

Since all exceptions extend `ArchSoft.Http.Exceptions`, you can use the factories from that package:

### Creating Exceptions by HTTP Status Code

```csharp
using ArchSoft.Http.Exceptions.Factories;
using System.Net;

// Create appropriate exception based on status code
var ex = HttpExceptionFactory.Create(HttpStatusCode.NotFound, "Resource not found");
throw ex;
```

### Mapping Exceptions to HTTP Status Codes

```csharp
using ArchSoft.Http.Exceptions.Factories;
using Microsoft.AspNetCore.Http;

public async Task InvokeAsync(HttpContext context)
{
    try
    {
        await _next(context);
    }
    catch (Exception ex)
    {
        // Automatically maps custom exceptions to appropriate HTTP status codes
        var statusCode = new HttpStatusCodeFactory().Create(ex);
        context.Response.StatusCode = (int)statusCode;
        await context.Response.WriteAsync(ex.Message);
    }
}
```

## Complete Middleware Example

```csharp
using System.Text.Json;
using ArchSoft.Http.Exceptions.Factories;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception occurred");

            var statusCode = new HttpStatusCodeFactory().Create(ex);
            context.Response.StatusCode = (int)statusCode;
            context.Response.ContentType = "application/json";

            var response = new
            {
                error = ex.Message,
                statusCode = (int)statusCode,
                timestamp = DateTime.UtcNow
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
```

Register in `Program.cs`:

```csharp
app.UseMiddleware<ExceptionHandlingMiddleware>();
```

## Requirements

- .NET 8.0 or .NET 9.0 (multi-targeted)
- [ArchSoft.Http.Exceptions](https://www.nuget.org/packages/ArchSoft.Http.Exceptions) 1.0.2 or higher

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

## About

Developed by [ArchSoft](https://github.com/archsoft-br) - Software Architecture Solutions
