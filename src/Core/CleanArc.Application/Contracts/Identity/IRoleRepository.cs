using CleanArc.Domain.Entities.User;

namespace CleanArc.Application.Contracts.Identity;

public interface IRoleRepository
{
    Task AddRoleAsync(ROLES role);
    Task<IEnumerable<ROLES>> GetAllRolesAsync();
    Task<ROLES> GetRoleByIdAsync(int roleId);
}