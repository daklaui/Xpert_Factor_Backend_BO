using CleanArc.Domain.Entities.User;
using System.Threading.Tasks;
using CleanArc.Application.Common;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IRolesRepository
    {
        Task AddRoleAsync(ROLES role);
        Task<PagedList<ROLES>> GetAllRolesAsync(PaginationParams paginationParams);
        Task<ROLES> GetRoleByIdAsync(int id);
       // Task<bool> UpdateRoleAsync(ROLES role);
    }
}