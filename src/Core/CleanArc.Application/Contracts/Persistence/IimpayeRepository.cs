using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Contracts.Persistence;

public interface IimpayeRepository
{
    Task AddImpayeAsync(T_IMPAYE impaye);
    Task<PagedList<T_IMPAYE_DTO>> getListOfImpaye(PaginationParams paginationParam);

}