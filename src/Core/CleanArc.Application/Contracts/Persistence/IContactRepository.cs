

using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IContactRepository
{
    Task AddContactAsync(T_CONTACT contact);
    Task<PagedList<T_CONTACT>> GetAllContactsAsync(PaginationParams paginationParams);
    Task<T_CONTACT> GetContactById(int id);
    Task<bool> UpdateContactAsync(int id, T_CONTACT updatedIndividu);
    Task<T_CONTACT> VerifContactExists(int id);
    Task<bool> ContactExistsTelAsync(int refIndiv, string phoneNumber);
    Task<bool> ContactExistsEmailAsync(int refIndiv, string email);
    Task<bool> ContactExistsByPositionAsync(int refIndiv, int position);

}