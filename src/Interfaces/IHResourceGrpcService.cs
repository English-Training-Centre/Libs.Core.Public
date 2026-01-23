using Libs.Core.Public.src.DTOs.Requests;
using Libs.Core.Public.src.DTOs.Responses;
using Libs.Core.Shared.src.DTOs.Responses;

namespace Libs.Core.Public.src.Interfaces;

public interface IHResourceGrpcService
{
    Task<HResourcesCreateResponse> CreateAsync(HResourcesCreateRequest request, CancellationToken ct);
    Task<IReadOnlyList<HResourcesGetAllResponse>> GetAllWithUserAsync(CancellationToken ct);
    Task<ResponseDTO> UpdateAsync(HResourcesUpdateRequest request, CancellationToken ct);
    Task<ResponseDTO> DeleteAsync(Guid id, CancellationToken ct);
}