using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

public class PostalCodesRepository:BaseAsyncRepository<TR_CP>,IPostalCodesRepository
{
    private readonly ApplicationDbContext _dbContext;

    public PostalCodesRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddTPostalCodesAsync(TR_CP trCp)
    {
       await  base.AddAsync(trCp);
    }

    public async Task<PagedList<TR_CP>> GetAllTPostalCodesAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<TR_CP>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        
        return result;
    }

    public async  Task<TR_CP> GetTPostalCodesById(int id)
    {
        return await base.TableNoTracking.FirstAsync(p=>p.ID_CP == id);    }

    public async Task<bool> UpdateTPostalCodesAsync(int id, TR_CP updatedTPostalCode)
    {
        var existingPostalCode = await base.Table.FirstOrDefaultAsync(e => e.ID_CP == id);

        if (existingPostalCode == null)
        {
            throw new InvalidOperationException($"TJobs with id {id} not found");
        }

        existingPostalCode.CP = updatedTPostalCode.CP;
        existingPostalCode.Ville = updatedTPostalCode.Ville;
        existingPostalCode.Code_Gouvernorat = updatedTPostalCode.Code_Gouvernorat;
        existingPostalCode.Gouvernorat = updatedTPostalCode.Gouvernorat;
        existingPostalCode.Code_Region = updatedTPostalCode.Code_Region;
    

        await base.UpdateAsync(existingPostalCode);

        return true;
    }
}