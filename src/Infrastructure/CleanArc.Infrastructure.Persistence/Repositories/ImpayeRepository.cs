using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class ImpayeRepository :BaseAsyncRepository<T_IMPAYE>,IimpayeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ImpayeRepository(ApplicationDbContext dbContext):base(dbContext)
    {
        _dbContext = dbContext;
    }
 
    public async Task AddImpayeAsync(T_IMPAYE impaye)
    {
        await base.AddAsync(impaye);

    }
    public async Task<PagedList<ListeDesImpayes>> GetListeDesImpayesAsync( PaginationParams paginationParams)
    {
        var liste = await _dbContext.ListeDesImpayes.FromSqlRaw("exec ListeDesImpayes").ToListAsync();
        
        var result = await PagedList<ListeDesImpayes>.CreateAsync(liste, paginationParams.PageNumber, paginationParams.PageSize);

        return result;
    }


}