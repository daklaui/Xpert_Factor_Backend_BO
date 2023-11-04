 

namespace CleanArc.Application.Contracts.Persistence;

public interface IIndividualRepository
{
    Task AddIIndividualAsync(TIndividu individu);
    Task<List<TIndividu>> GetAllIndividusAsync();
    //Task<List<Individu>> GetAllOrdersWithRelatedUserAsync();
}