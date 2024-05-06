using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities.User;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    public class RolesRepository : BaseAsyncRepository<ROLES>, IRolesRepository
    {
        public RolesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddRoleAsync(ROLES role)
        {
            await base.AddAsync(role);
        }

        public async Task<PagedList<ROLES>> GetAllRolesAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.Include(r => r.Permissions).AsQueryable();
            var result = await PagedList<ROLES>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
            
            return result;
        }

        public async Task<ROLES> GetRoleByIdAsync(int id)
        {
            return await base.TableNoTracking.Include(r => r.Permissions).FirstOrDefaultAsync(r => r.Id == id);
        }

        

        /* public async Task<bool> UpdateRoleAsync(ROLES updatedRole)
        {
            var existingRole = await base.Table.Include(r => r.Permissions).FirstOrDefaultAsync(r => r.Id == updatedRole.Id);

            if (existingRole == null)
            {
                throw new InvalidOperationException($"Role with Id {updatedRole.Id} not found");
            }

            // Update the role properties here
            existingRole.Name = updatedRole.Name;
            // Handle the Permissions collection update if necessary

            await base.UpdateAsync(existingRole);

            return true;
        }*/
    }
       
}