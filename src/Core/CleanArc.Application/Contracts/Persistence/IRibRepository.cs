

using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IRibRepository
{
    Task AddRibAsync(TR_RIB contact);
    Task<PagedList<TR_RIB>> GetAllRibsByIndividuAsync(PaginationParams paginationParams);
    Task<TR_RIB> GetRibById(int id);
    //Task<List<Individu>> GetAllOrdersWithRelatedUserAsync();
}