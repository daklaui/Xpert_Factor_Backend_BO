using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities.Order;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class IndividuRepository : BaseAsyncRepository<TIndividu>, IIndividualRepository
{
    public IndividuRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddIIndividualAsync(TIndividu individu)
    {
        await base.AddAsync(individu);
    }

    public  async Task<PagedList<TIndividu>> GetAllIndividusAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<TIndividu>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        
        return result;
    }

    public async Task<TIndividu> GetIndividuById(int id)
    {
          return await base.TableNoTracking.FirstAsync(p=>p.Id == id);
    }
}