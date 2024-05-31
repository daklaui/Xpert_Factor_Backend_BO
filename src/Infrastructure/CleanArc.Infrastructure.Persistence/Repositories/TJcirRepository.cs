using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class TJcirRepository: BaseAsyncRepository<TJ_CIR> , ITjcirRepository
{
    private readonly ApplicationDbContext _dbContext;

    public TJcirRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddTJCIRsync(TJ_CIR buyer)
    {
        await base.AddAsync(buyer);
    }

    public async Task AddBuyer(BuyerDTO buyerDto)
    {
        var buyerEntity = new TJ_CIR
        {
            REF_CTR_CIR = buyerDto.REF_CTR_CIR,
            REF_IND_CIR = buyerDto.REF_IND_CIR,
        };
        await base.AddAsync(buyerEntity);
    }


    public async Task<PagedList<TJ_CIR>> GetAllCirAsync(PaginationParams paginationParams)
    {
        var query = base.TableNoTracking.AsQueryable();
        var result = await PagedList<TJ_CIR>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        
        return result;
    }   
    
    public async Task<TJ_CIR> GetExistingActorsByRefCtr(string role, int refCtr)
    {
        var query = base.TableNoTracking.Where(p => p.ID_ROLE_CIR == role.ToUpper() && p.REF_CTR_CIR == refCtr);
        return await query.FirstOrDefaultAsync() ;
    }



    public Task<PagedList<TJ_CIR>> GetAllCIRAsync(PaginationParams paginationParams)
    {
        throw new NotImplementedException();
    }

    public async Task<TJ_CIR> GetCIRById(int id)
    {
        return await base.TableNoTracking.FirstAsync(p=>p.ID_CIR == id);
    }
    public async Task<bool> UpdateCirAsync(TJ_CIR updatedCir)
    {
        var existingCir = await base.Table.FirstOrDefaultAsync(p => p.REF_CTR_CIR == updatedCir.REF_CTR_CIR && p.REF_IND_CIR == updatedCir.REF_IND_CIR && p.ID_ROLE_CIR == updatedCir.ID_ROLE_CIR);

        if (existingCir == null)
        {
            throw new InvalidOperationException("");
        }

        await base.UpdateAsync(existingCir);

        return true;
    }
    
    
    public async Task<List<AcheteurDto>> GetAcheteursByContratAsync(int refCtrCir)
    {
        Console.WriteLine($"Fetching acheteurs for REF_CTR_CIR = {refCtrCir}");
        var acheteurs = await base.Table
            .Where(cir => cir.REF_CTR_CIR == refCtrCir && cir.ID_ROLE_CIR == "ach")
            .Select(cir => new AcheteurDto
            {
                IdCir = cir.ID_CIR,
                RefIndCir = cir.REF_IND_CIR
            })
            .ToListAsync();
        Console.WriteLine($"Acheteurs count for REF_CTR_CIR = {refCtrCir}: {acheteurs.Count}");

        return acheteurs;
    }


    public void SaveChanges()
    {
        throw new NotImplementedException();
    }
}