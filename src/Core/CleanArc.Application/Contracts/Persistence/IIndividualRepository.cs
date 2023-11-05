

using CleanArc.Application.Common;

namespace CleanArc.Application.Contracts.Persistence;

public interface IIndividualRepository
{
    Task AddIIndividualAsync(TIndividu individu);
    Task<PagedList<TIndividu>> GetAllIndividusAsync(PaginationParams paginationParams);
    Task<TIndividu> GetIndividuById(int id);
    //Task<List<Individu>> GetAllOrdersWithRelatedUserAsync();
}