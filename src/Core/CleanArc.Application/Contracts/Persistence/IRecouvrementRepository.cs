using CleanArc.Application.Common;
using CleanArc.Application.Models.Identity;

namespace CleanArc.Application.Contracts.Persistence;

public interface IRecouvrementRepository
{
    Task<List<RecouvrementDto>> GetAllRecouvrementAsync(PaginationParams paginationParams);
    
}