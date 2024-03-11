using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class TMMRepository :BaseAsyncRepository<TR_TMM>, ITMMRepository
{
    public TMMRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddTrTmmAsync(TR_TMM trTmm)
    {
        await base.AddAsync(trTmm);
    }

    public async Task<PagedList<TR_TMM>> GetAllTrTmmAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<TR_TMM>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        
        return result;
    }

    public async Task<TR_TMM> GetTrTmmById(int id)
    {
        return await base.TableNoTracking.FirstAsync(p=>p.ID_TMM == id);

    }

    public  async Task UpdateTrTmmAsync(TR_TMM trTmm)
    {
        throw new NotImplementedException();
    }
}