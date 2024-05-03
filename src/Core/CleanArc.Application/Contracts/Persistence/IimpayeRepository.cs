using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Contracts.Persistence;

public interface IimpayeRepository
{
    Task AddImpayeAsync(T_IMPAYE impaye);
   // Task<List<ListeDesImpayes>> GetListeDesImpayesAsync(PaginationParams paginationParams);
   Task<PagedList<T_IMPAYE_DTO>> GetListeDesImpayesAsync(PaginationParams paginationParams);
}