namespace Libs.Core.Public.src.DTOs.Responses;

public sealed record RoleGetAllResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}