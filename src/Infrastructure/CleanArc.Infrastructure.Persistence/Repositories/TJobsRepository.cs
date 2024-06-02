using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class TJobsRepository:BaseAsyncRepository<TR_ACTPROF_BCT>,ITJobsRepository
{
    private readonly ApplicationDbContext _dbContext;

    public TJobsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async  Task AddTJobsAsync(TR_ACTPROF_BCT actprofBct)
    {
        await base.AddAsync(actprofBct);
    }

    public async Task<List<TR_ACTPROF_BCT>> GetAllTJobsAsync()
    {
        var query = base.TableNoTracking.AsQueryable();
        return await query.ToListAsync();
    }

   

    public async Task<TR_ACTPROF_BCT> GetTJobsById(string id)
    {
        return await base.TableNoTracking.FirstAsync(p=>p.Code_Section == id);

    }

    public async Task<bool> UpdateTJobsAsync(string id, TR_ACTPROF_BCT updatedTJobs)
    {
       var existingTJobs = await base.Table.FirstOrDefaultAsync(e => e.Code_Section == id);

    if (existingTJobs == null)
    {
        throw new InvalidOperationException($"TJobs with id {id} not found");
    }

    existingTJobs.Code_Section = updatedTJobs.Code_Section;
    existingTJobs.Section= updatedTJobs.Section;
    
    existingTJobs.Code_SousSection= updatedTJobs.Code_SousSection;
    existingTJobs.SousSection= updatedTJobs.SousSection;
    
    existingTJobs.Classe = updatedTJobs.Classe;
    existingTJobs.SousClasse= updatedTJobs.SousClasse;
    existingTJobs.Code_SousClasse= updatedTJobs.Code_SousClasse;

    existingTJobs.Code_Classe1 = updatedTJobs.Code_Classe1;
    existingTJobs.Code_Activité = updatedTJobs.Code_Activité;
    
    existingTJobs.Code_Classe= updatedTJobs.Code_Classe;


    await base.UpdateAsync(existingTJobs);

    return true;
    }
}