using CleanArc.Application.Common;
using CleanArc.Domain.DTO;

namespace CleanArc.Application.Contracts.Persistence;

public interface IGEDRepository
{
    Task<List<GEDNumerisationDTO>> GetAllGEDNumerisationAsync(PaginationParams paginationParams);
    Task<List<GEDValidationDTO>> GetAllGEDValidationAsync(PaginationParams paginationParams);
}