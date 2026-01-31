using Libs.Core.Public.src.DTOs.Requests;
using Libs.Core.Public.src.DTOs.Responses;

namespace Libs.Core.Public.src.Interfaces;

public interface IStudentGrpcService
{
    Task<StudentGrpcCreateResponse> CreateAsync(StudentGrpcCreateRequest request, CancellationToken ct);
}