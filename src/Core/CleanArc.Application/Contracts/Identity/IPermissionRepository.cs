using CleanArc.Domain.Entities.User;
using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArc.Application.Common;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IPermissionRepository 
    {
        Task<Permission> GetPermissionByIdAsync(int id);
        Task<IEnumerable<Permission>> GetAllPermissionsAsync();
        Task AddPermissionAsync(Permission permission);
        Task<bool> UpdatePermissionAsync(Permission permission);
    }
}