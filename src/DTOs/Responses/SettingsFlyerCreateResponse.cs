using System.Text.Json.Serialization;

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
    [JsonPropertyName("package")]
    public string Package { get; set; } = string.Empty;
    [JsonPropertyName("modality")]
    public string Modality { get; set; } = string.Empty;

    [JsonPropertyName("levelA")]
    public long LevelA { get; set; }
    [JsonPropertyName("levelAA")]
    public long LevelAA { get; set; }
    [JsonPropertyName("levelB")]
    public long LevelB { get; set; }
    [JsonPropertyName("levelBB")]
    public long LevelBB { get; set; }
    [JsonPropertyName("levelC")]
    public long LevelC { get; set; }
}
