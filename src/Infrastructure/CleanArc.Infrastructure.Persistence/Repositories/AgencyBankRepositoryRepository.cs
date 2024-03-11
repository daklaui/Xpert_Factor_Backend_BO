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

    public async Task UpdateTrAgencyBankAsync(TR_Ag_Bq updateTrAgBq)
    {
        await base.UpdateAsync1(updateTrAgBq);

    }

}