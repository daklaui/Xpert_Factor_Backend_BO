

using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IContactRepository
{
    Task AddContactAsync(T_CONTACT contact);
    Task<PagedList<T_CONTACT>> GetAllContactsByIndividuAsync(PaginationParams paginationParams);
    Task<T_CONTACT> GetContactById(int id);
    //Task<List<Individu>> GetAllOrdersWithRelatedUserAsync();
}