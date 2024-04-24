

using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IIndividualRepository
{
    Task AddIIndividualAsync(T_INDIVIDU individu);
    Task<PagedList<T_INDIVIDU>> GetAllIndividusAsync(PaginationParams paginationParams);
    Task<T_INDIVIDU> GetIndividuById(int id);
    
    Task<bool> UpdateIndividuAsync(int id, T_INDIVIDU updatedIndividu);
}