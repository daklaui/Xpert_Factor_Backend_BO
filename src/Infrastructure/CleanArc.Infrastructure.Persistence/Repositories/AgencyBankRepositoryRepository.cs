using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class AgencyBankRepositoryRepository : BaseAsyncRepository<TR_Ag_Bq>, IAgencyBankRepository
{
    private readonly ApplicationDbContext _dbContext;

    public AgencyBankRepositoryRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<TR_Ag_Bq> AddTrAgencyBankAsync(TR_Ag_Bq trAgBq)
    {
        if (trAgBq == null)
        {
            throw new ArgumentNullException(nameof(trAgBq), "Cannot add a null entity");
        }

        await base.AddAsync(trAgBq);
        return trAgBq;
    }

    public async Task<PagedList<TR_Ag_Bq>> GetAllTrAgencyBankAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        return await PagedList<TR_Ag_Bq>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
    }

    public async Task<TR_Ag_Bq> GetTrAgencyBankById(string code)
    {
        return await base.TableNoTracking.FirstOrDefaultAsync(p => p.Code_Bq_Ag == code);
    }

    public async Task<string> SearchBank(string codeBank)
    {
        string nameBank = "";
        try
        {
            nameBank = base.Table.Where(p => p.Code_Bq == codeBank).Select(p => p.Banque).FirstOrDefault();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return nameBank;
    }
    public async Task <string>  ResearchAgency(string codeAgency)
    {
        string nameAgency = "";
       
        try
        {
            nameAgency = base.Table.Where(p => p.Code_Ag== codeAgency).Select(p => p.Agence).FirstOrDefault();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return nameAgency;

    }

    public async Task<bool>  UpdateTrAgencyBankAsync(String code,TR_Ag_Bq updateAgBq)
    {
        var existingAgBq = await base.Table.FirstOrDefaultAsync(p => p.Code_Bq_Ag ==code);

        if (existingAgBq == null)
        {
            throw new InvalidOperationException($" AgBq with id {code} not found");
        }

        existingAgBq.Code_Bq_Ag = updateAgBq.Code_Bq_Ag; 
        existingAgBq.Code_Bq = updateAgBq.Code_Bq;
        existingAgBq.Code_Ag = updateAgBq.Code_Ag;
        existingAgBq.Agence = updateAgBq.Agence;
        existingAgBq.Banque = updateAgBq.Banque;
        
        await base.UpdateAsync(existingAgBq);
        return true;

    }

}