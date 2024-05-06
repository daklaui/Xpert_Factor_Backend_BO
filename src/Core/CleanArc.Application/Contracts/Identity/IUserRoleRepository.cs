using CleanArc.Domain.Entities.User;

namespace CleanArc.Application.Contracts.Identity;

public interface IUserRoleRepository
{
    Task<IEnumerable<UserROLES>> GetAllUserRolesAsync();
    Task<UserROLES> GetUserRoleByIdAsync(int userRoleId);
}