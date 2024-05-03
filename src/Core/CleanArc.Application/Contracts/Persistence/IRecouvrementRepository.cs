using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IRecouvrementRepository
{
    Task<PagedList<TR_LIST_VAL>> GetAllRecAsync(PaginationParams paginationParams);

    Task AddRecouvrementAsync(TR_LIST_VAL Recouvrement);
}