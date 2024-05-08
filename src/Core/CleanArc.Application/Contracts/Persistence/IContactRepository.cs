

using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IContactRepository
{
    Task AddContactAsync(T_CONTACT contact);
    Task<PagedList<T_CONTACT>> GetAllContactsAsync(PaginationParams paginationParams);
    Task<T_CONTACT> GetContactById(int id);
    Task<bool> UpdateContactAsync(int id, T_CONTACT updatedIndividu);

}