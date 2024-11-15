using System.Net;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace ExampleMicroservice.Shared;

public class ServiceResult
{
    [JsonIgnore] public HttpStatusCode Status { get; set; }

    public ProblemDetails? Fail { get; set; }

    [JsonIgnore] public bool IsSuccess => Fail is null;

    [JsonIgnore] public bool IsFail => !IsSuccess;
    
    public static ServiceResult SuccessAsNoContent() => new ServiceResult { Status = HttpStatusCode.NoContent };
    
    public static ServiceResult ErrorAsNoFound() => new ServiceResult { Status = HttpStatusCode.NotFound, Fail = new ProblemDetails { Title = "Not Found", Detail = "The requested resource was not found." } };
}

public class ServiceResult<T> : ServiceResult
{
}