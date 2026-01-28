namespace Libs.Core.Public.src.DTOs.Responses;

public sealed record SettingsFlyerCreateResponse
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public long EnrolmentFee { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }

    public List<MonthlyTuitionResponse> MonthlyTuitions { get; set; } = [];
}

public sealed record MonthlyTuitionResponse
{
    public string Package { get; set; } = string.Empty;
    public string Modality { get; set; } = string.Empty;

    public long LevelA { get; set; }
    public long LevelAA { get; set; }
    public long LevelB { get; set; }
    public long LevelBB { get; set; }
    public long LevelC { get; set; }
}
