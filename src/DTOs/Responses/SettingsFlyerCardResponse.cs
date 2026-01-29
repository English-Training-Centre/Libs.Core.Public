namespace Libs.Core.Public.src.DTOs.Responses;

public sealed record SettingsFlyerCardResponse
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public long EnrolmentFee { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}