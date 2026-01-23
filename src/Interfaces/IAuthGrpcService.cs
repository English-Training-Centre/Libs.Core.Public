using Libs.Core.Public.src.DTOs.Requests;
using Libs.Core.Public.src.DTOs.Responses;
using Libs.Core.Shared.src.DTOs.Requests;

namespace Libs.Core.Public.src.Interfaces;

public interface IAuthGrpcService
{
    Task<AuthResponse> SignInAsync(UserAuthRequest request, CancellationToken ct);
    Task<AuthResponse> RefreshTokenAsync(RefreshTokenRequest request, CancellationToken ct);    
    Task<RefreshTokenResponse?> GetValidRefreshTokenAsync(string refreshToken, CancellationToken ct);
    Task RevokeRefreshTokenAsync(string refreshToken, CancellationToken ct);
    Task<CheckSessionResponse> CheckSessionAsync(Guid userId, CancellationToken ct);
}