namespace Libs.Core.Public.src.DTOs.Requests;

public sealed record StudentGrpcCreateRequest
(
    string CourseModality,
    string CoursePackage,
    string CourseLevel,
    string CourseTime,
    Guid StudentRoleId,
    string StudentFullName,
    string StudentGender,
    DateTime StudentBirthDate,
    string? StudentEmail,
    string StudentPhoneNumber,       
    string ResidencialAddress,
    string GuardianFullName,
    string GuardianPhoneNumber
);