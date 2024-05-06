using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities.User;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    public class PermissionRepository : BaseAsyncRepository<Permission>, IPermissionRepository
    {
        public async Task AddPermissionAsync(Permission permission)
        {
            await base.AddAsync(permission);
        }
        
        
        public PermissionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Task<Permission> GetPermissionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Permission>> GetAllPermissionsAsync()
        {
            throw new NotImplementedException();
        }

       

        public Task<bool> UpdatePermissionAsync(Permission permission)
        {
            throw new NotImplementedException();
        }

        // Les autres méthodes de votre repository...
    }
}