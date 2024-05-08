using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories;

internal class TJ_DOCUMENT_DET_BORD_Repository : BaseAsyncRepository<TJ_DOCUMENT_DET_BORD>, ITJ_DOCUMENT_DET_BORD_Repository
{
    private readonly ApplicationDbContext _dbContext;

    public TJ_DOCUMENT_DET_BORD_Repository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task addTj_documentAsync(TJ_DOCUMENT_DET_BORD Tj_document)
    {
        await base.AddAsync(Tj_document);
    }
    public async Task<IEnumerable<TJ_DOCUMENT_DET_BORD>> GetDocumentDetBordByPK(string numBord, int refCtr)
    {
        var query = base.Table.Where(x => 
            x.NUM_BORD == numBord && 
            x.REF_CTR_DET_BORD == refCtr);

        return await query.ToListAsync();   
    }
    public async Task<PagedList<TJ_DOCUMENT_DET_BORD>> GetAllTj_documentAsync(PaginationParams paginationParams)
    {
           
        var query = base.TableNoTracking.AsQueryable();

        var result = await PagedList<TJ_DOCUMENT_DET_BORD>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

        return result;
    }
    public async Task<bool> UpdateDocumentDetBordAsync(PksTjDetBord pksDto, TJ_DOCUMENT_DET_BORD updatedDocumentDetBord)
    {
      
        var existingDocumentDetBordList = await GetDocumentDetBordByPK(pksDto.NUM_BORD, pksDto.REF_CTR_DET_BORD);
        
        if (existingDocumentDetBordList == null || !existingDocumentDetBordList.Any())
        {
            throw new InvalidOperationException($"DocumentDetBord with primary keys (NUM_BORD: {pksDto.NUM_BORD}, REF_CTR_DET_BORD: {pksDto.REF_CTR_DET_BORD}) not found.");
        }
        
        foreach (var existingDocumentDetBord in existingDocumentDetBordList)
        {
            existingDocumentDetBord.ID_DET_BORD = updatedDocumentDetBord.ID_DET_BORD;
            existingDocumentDetBord.REF_DOCUMENT_DET_BORD = updatedDocumentDetBord.REF_DOCUMENT_DET_BORD;
            _dbContext.Entry(existingDocumentDetBord).State = EntityState.Modified;
        }
        await _dbContext.SaveChangesAsync();
        return true;
    }

    
    public async Task<TJ_DOCUMENT_DET_BORD> GetTj_documentById(int id)
    {
        return await base.TableNoTracking.FirstOrDefaultAsync(p => p.ID_DOCUMENT_DET_BORD == id); // Assuming Id property
    }
    
    public async Task DeleteTj_document(TJ_DOCUMENT_DET_BORD Tj_document)
    {
        _dbContext.Set<TJ_DOCUMENT_DET_BORD>().Remove(Tj_document);
    }
}