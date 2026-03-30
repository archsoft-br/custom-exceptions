# ArchSoft.CustomExceptions

[![NuGet](https://img.shields.io/nuget/v/ArchSoft.CustomExceptions.svg)](https://www.nuget.org/packages/ArchSoft.CustomExceptions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-8.0%20%7C%209.0-blue.svg)](https://dotnet.microsoft.com)

[English](README.md) | **Português (Brasil)**

Uma coleção abrangente de **exceções customizadas específicas de domínio** para aplicações .NET. Esta biblioteca estende o [ArchSoft.Http.Exceptions](https://github.com/archsoft-br/http-exceptions) para fornecer exceções tipadas para cenários comuns como regras de negócio, gerenciamento de recursos, segurança e mais.

---

## Instalação

```bash
dotnet add package ArchSoft.CustomExceptions
```

## Recursos

- **Exceções específicas de domínio** – Negócio, Recurso, Segurança, Concorrência e mais
- **Baseado em exceções HTTP** – Estende `ArchSoft.Http.Exceptions` para integração seamless com APIs
- **Suporte ao padrão Factory** – Use `HttpExceptionFactory` e `HttpStatusCodeFactory` da biblioteca base
- **Clean Architecture friendly** – Separe erros de domínio das camadas de transporte

## Categorias de Exceções

### Api

Exceções para falhas de comunicação com APIs.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `RequestException` | `BadRequestException` | 400 | Formato ou parâmetros de requisição inválidos |
| `ResponseException` | `InternalServerErrorException` | 500 | Resposta de API inválida ou inesperada |

### Auth

Exceções de autenticação e autorização.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `AuthenticationException` | `ForbiddenException` | 403 | Falha de autenticação (credenciais inválidas) |
| `AuthorizationException` | `UnauthorizedException` | 401 | Falha de autorização (permissões insuficientes) |

### Broker

Exceções de message broker (Kafka, RabbitMQ, etc.).

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `BrokerException` | `BadGatewayException` | 502 | Erro geral de comunicação com broker |
| `ConsumerException` | `BadGatewayException` | 502 | Falha no consumo de mensagens |
| `ProducerException` | `BadGatewayException` | 502 | Falha no envio/publicação de mensagens |

### Business

Exceções de validação de regras de negócio.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `BusinessException` | `UnprocessableEntityException` | 422 | Violação genérica de regra de negócio |
| `RuleException` | `UnprocessableEntityException` | 422 | Violação específica de regra de negócio |
| `ValidationException` | `UnprocessableEntityException` | 422 | Falha de validação de entrada |

### Concurrency

Exceções de controle de concorrência.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `ConcurrencyException` | `ConflictException` | 409 | Modificação concorrente detectada |
| `VersionMismatchException` | `ConflictException` | 409 | Conflito de versão (optimistic locking) |

### Configuration

Exceções relacionadas a configuração.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `ConfigurationException` | `InternalServerErrorException` | 500 | Valor de configuração ausente ou inválido |

### Integration

Exceções de integração com serviços externos.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `IntegrationException` | `BadGatewayException` | 502 | Falha de integração com serviço externo |

### IO

Exceções de operações de Entrada/Saída.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `InputException` | `BadRequestException` | 400 | Erro de leitura ou parsing de entrada |
| `OutputException` | `InternalServerErrorException` | 500 | Erro de escrita de saída |

### Operation

Exceções de operações gerais.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `OperationException` | `ConflictException` | 409 | Falha genérica de operação |

### Process

Exceções de processamento de dados.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `ProcessException` | `UnprocessableEntityException` | 422 | Erro geral de processamento |
| `MapException` | `UnprocessableEntityException` | 422 | Falha de mapeamento de objetos |
| `ParseException` | `UnprocessableEntityException` | 422 | Falha de parsing de dados |

### Resource

Exceções de gerenciamento de recursos.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `ResourceNotFoundException` | `NotFoundException` | 404 | Recurso não existe |
| `ResourceAlreadyExistsException` | `ConflictException` | 409 | Tentativa de criação de recurso duplicado |
| `ResourceExhaustedException` | `TooManyRequestsException` | 429 | Cota ou capacidade de recurso excedida |

### Resilience

Exceções de padrões de resiliência (circuit breaker, rate limiting, etc.).

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `RateLimitExceededException` | `TooManyRequestsException` | 429 | Cota de rate limit excedida |
| `ThrottlingException` | `TooManyRequestsException` | 429 | Throttling de requisições aplicado |
| `IdempotencyException` | `ConflictException` | 409 | Conflito de chave de idempotência |

### Security

Exceções relacionadas a segurança.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `EncryptionException` | `InternalServerErrorException` | 500 | Falha de criptografia de dados |
| `DecryptionException` | `InternalServerErrorException` | 500 | Falha de descriptografia de dados |
| `InvalidSignatureException` | `ForbiddenException` | 403 | Falha de validação de assinatura criptográfica |

### Unavailable

Exceções de disponibilidade de serviço.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `UnavailableException` | `ServiceUnavailableException` | 503 | Serviço temporariamente indisponível |

### Unexpected

Exceções de erros inesperados.

| Exceção | Exceção HTTP Base | Código HTTP | Quando Usar |
|---------|-------------------|-------------|-------------|
| `UnexpectedException` | `InternalServerErrorException` | 500 | Erro inesperado/não tratado |

---

## Exemplos de Uso

### Uso Básico

```csharp
using ArchSoft.CustomExceptions.Exceptions.Resource;

public class UserService
{
    public User GetUser(Guid id)
    {
        var user = _repository.Find(id);

        if (user == null)
            throw new ResourceNotFoundException($"Usuário com id {id} não encontrado");

        return user;
    }
}
```

### Validação de Regras de Negócio

```csharp
using ArchSoft.CustomExceptions.Exceptions.Business;

public class OrderService
{
    public void PlaceOrder(OrderRequest request)
    {
        if (request.Items.Count == 0)
            throw new ValidationException("O pedido deve conter pelo menos um item");

        if (request.TotalAmount <= 0)
            throw new RuleException("O valor total do pedido deve ser maior que zero");

        // Processa pedido...
    }
}
```

### Controle de Concorrência

```csharp
using ArchSoft.CustomExceptions.Exceptions.Concurrency;

public class DocumentService
{
    public void UpdateDocument(Guid id, DocumentUpdate update, long expectedVersion)
    {
        var document = _repository.Get(id);

        if (document.Version != expectedVersion)
            throw new VersionMismatchException(
                $"Conflito de versão do documento. Esperado: {expectedVersion}, Atual: {document.Version}");

        // Atualiza documento...
    }
}
```

### Operações de Segurança

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
            throw new DecryptionException("Falha ao descriptografar dados", ex);
        }
    }
}
```

## Usando Factories

Como todas as exceções estendem `ArchSoft.Http.Exceptions`, você pode usar as factories daquele pacote:

### Criando Exceções por Código HTTP

```csharp
using ArchSoft.Http.Exceptions.Factories;
using System.Net;

// Cria exceção apropriada baseada no código de status
var ex = HttpExceptionFactory.Create(HttpStatusCode.NotFound, "Recurso não encontrado");
throw ex;
```

### Mapeando Exceções para Códigos HTTP

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
        // Mapeia automaticamente exceções customizadas para códigos HTTP apropriados
        var statusCode = new HttpStatusCodeFactory().Create(ex);
        context.Response.StatusCode = (int)statusCode;
        await context.Response.WriteAsync(ex.Message);
    }
}
```

## Exemplo Completo de Middleware

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
            _logger.LogError(ex, "Ocorreu uma exceção não tratada");

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

Registre em `Program.cs`:

```csharp
app.UseMiddleware<ExceptionHandlingMiddleware>();
```

## Requisitos

- .NET 8.0 ou .NET 9.0 (multi-target)
- [ArchSoft.Http.Exceptions](https://www.nuget.org/packages/ArchSoft.Http.Exceptions) 1.0.2 ou superior

## Contribuindo

Contribuições são bem-vindas! Por favor, sinta-se à vontade para enviar um Pull Request. Para mudanças maiores, abra uma issue primeiro para discutir o que você gostaria de alterar.

## Licença

Este projeto está licenciado sob a **Licença MIT** - veja o arquivo [LICENSE](LICENSE) para detalhes.

## Sobre

Desenvolvido por [ArchSoft](https://github.com/archsoft-br) - Soluções em Arquitetura de Software
