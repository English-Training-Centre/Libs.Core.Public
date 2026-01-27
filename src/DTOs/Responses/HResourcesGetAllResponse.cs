namespace Libs.Core.Public.src.DTOs.Responses;

public sealed record HResourcesGetAllResponse
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string Role { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public bool IsActive { get; set; }
    public string Position { get; set; } = string.Empty;
    public long Subsidy { get; set; }
}