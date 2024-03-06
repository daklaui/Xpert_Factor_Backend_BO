using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.Order;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class IndividuRepository : BaseAsyncRepository<T_INDIVIDU>, IIndividualRepository
{
    public IndividuRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddIIndividualAsync(T_INDIVIDU individu)
    {
        await base.AddAsync(individu);
    }

    public  async Task<PagedList<T_INDIVIDU>> GetAllIndividusAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<T_INDIVIDU>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        
        return result;
    }

    public async Task<T_INDIVIDU> GetIndividuById(int id)
    {
          return await base.TableNoTracking.FirstAsync(p=>p.REF_IND == id);
    }
}