 

namespace CleanArc.Application.Contracts.Persistence;

public interface IIndividualRepository
{
    Task AddIIndividualAsync(TIndividu individu);
    Task<List<TIndividu>> GetAllIndividusAsync();
    Task<TIndividu> GetIndividuById(int id);
    //Task<List<Individu>> GetAllOrdersWithRelatedUserAsync();
}