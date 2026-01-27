namespace Libs.Core.Public.src.DTOs.Responses;

public sealed record SettingsFlyerCreateResponse
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; } = default!;
    public decimal EnrolmentFee { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }

    public List<MonthlyTuitionResponse> MonthlyTuitions { get; set; } = [];
}

public sealed record MonthlyTuitionResponse
{
    public string Package { get; set; } = default!;
    public string Modality { get; set; } = default!;

    public decimal LevelA { get; set; }
    public decimal LevelAA { get; set; }
    public decimal LevelB { get; set; }
    public decimal LevelBB { get; set; }
    public decimal LevelC { get; set; }
}
