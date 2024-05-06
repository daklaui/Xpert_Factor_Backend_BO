using System;
using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class UserRepository : BaseAsyncRepository<TS_USER>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddUserAsync(TS_USER user)
        {
            await base.AddAsync(user);
        }
         
        public async Task<PagedList<TS_USER>> GetAllUsersAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<TS_USER>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
            
            return result;
        }

        public async Task<TS_USER> GetUserById(int id)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.ID_USER == id);
        }    
        
        
    }
}