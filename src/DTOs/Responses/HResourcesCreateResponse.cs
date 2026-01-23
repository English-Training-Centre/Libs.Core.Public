namespace Libs.Core.Public.src.DTOs.Responses;

public sealed record HResourcesCreateResponse
{
    public bool IsSuccess { get; init; }
    public string? Message { get; init; }
    public string? Username { get; init; }
    public string? Password { get; init; }
}