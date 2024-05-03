using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IimpayeRepository
{
    Task AddImpayeAsync(T_IMPAYE impaye);
   // Task<List<ListeDesImpayes>> GetListeDesImpayesAsync(PaginationParams paginationParams);
   Task<PagedList<ListeDesImpayes>> GetListeDesImpayesAsync(PaginationParams paginationParams);
}