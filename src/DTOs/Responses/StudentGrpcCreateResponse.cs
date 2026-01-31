namespace Libs.Core.Public.src.DTOs.Responses;

public sealed record StudentGrpcCreateResponse
{
    public bool IsSuccess { get; set; }
    public string? Message { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
}