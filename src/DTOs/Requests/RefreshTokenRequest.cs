namespace Libs.Core.Public.src.DTOs.Requests;

public sealed record RefreshTokenRequest
(
    Guid UserId,
    string RefreshToken
);