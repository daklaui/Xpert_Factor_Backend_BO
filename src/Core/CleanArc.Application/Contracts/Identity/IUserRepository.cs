using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using System.Threading.Tasks;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IUserRepository 
    {
        Task AddUserAsync(TS_USER user);
        Task<PagedList<TS_USER>> GetAllUsersAsync(PaginationParams paginationParams);
        Task<TS_USER> GetUserById(int id);
        
    }
}
