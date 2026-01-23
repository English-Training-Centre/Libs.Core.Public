namespace Libs.Core.Public.src.DTOs.Requests;

public sealed record HResourcesCreateRequest
(
    string FullName,
    string PhoneNumber,
    string? Email,
    Guid RoleId,
    string Position,
    long Subsidy
);