namespace Libs.Core.Public.src.DTOs.Responses;

public sealed record RoleGetAllResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
}