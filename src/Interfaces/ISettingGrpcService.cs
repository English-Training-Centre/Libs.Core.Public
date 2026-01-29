using Libs.Core.Public.src.DTOs.Requests;
using Libs.Core.Public.src.DTOs.Responses;
using Libs.Core.Shared.src.DTOs.Responses;

namespace Libs.Core.Public.src.Interfaces;

public interface ISettingGrpcService
{
    Task<ResponseDTO> CreateFlyer(SettingsFlyerCreateRequest request, CancellationToken ct);
    Task<IReadOnlyList<SettingsFlyerCreateResponse>> GetAllFlyer(CancellationToken ct);
}
