using Libs.Core.Public.src.DTOs.Requests;
using Libs.Core.Public.src.DTOs.Responses;
using Libs.Core.Shared.src.DTOs.Responses;

namespace Libs.Core.Public.src.Interfaces;

public interface ISettingGrpcService
{
    Task<ResponseDTO> CreateFlyerAsync(SettingsFlyerCreateRequest request, CancellationToken ct);
    Task<IReadOnlyList<SettingsFlyerCardResponse>> GetCardFlyerAsync(CancellationToken ct);
    Task<IReadOnlyList<SettingsFlyerCreateResponse>> GetAllFlyerAsync(CancellationToken ct);
}
