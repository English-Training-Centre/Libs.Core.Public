using Libs.Core.Public.src.DTOs.Responses;

namespace Libs.Core.Public.src.Interfaces;

public interface IRoleGrpcService
{
    Task<IEnumerable<RoleGetAllResponse>> GetAllAsync(CancellationToken ct);
}