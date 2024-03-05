using System.Data.Entity;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class AgBqRepository :BaseAsyncRepository<TRAgBq>,IAgBqRepository
{
    public AgBqRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<TRAgBq> GetAgBqByIdAsync(int id)
    {
        return await base.TableNoTracking.FirstAsync(p=>p.Id == id);
    }

    public async Task<PagedList<TRAgBq>> GetAllAgBqAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<TRAgBq>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        
        return result;
    }

    public async Task AddAgBqAsync(TRAgBq agBq)
    {
        await base.AddAsync(agBq);
    }

    public async Task UpdateAgBqAsync(TRAgBq agBq)
    {
        await base.UpdateAsync(agBq);    }
}