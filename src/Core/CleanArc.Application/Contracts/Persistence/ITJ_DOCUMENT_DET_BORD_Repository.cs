using CleanArc.Application.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ITJ_DOCUMENT_DET_BORD_Repository
{
    Task addTj_documentAsync(TJ_DOCUMENT_DET_BORD Tj_document);
    
    Task<PagedList<TJ_DOCUMENT_DET_BORD>> GetAllTj_documentAsync(PaginationParams paginationParams);
    Task<IEnumerable<TJ_DOCUMENT_DET_BORD>> GetDocumentDetBordByPK(string numBord, int refCtr);
    Task<TJ_DOCUMENT_DET_BORD> GetTj_documentById(int id);
    Task<bool> UpdateDocumentDetBordAsync(PksTjDetBord pksDto, TJ_DOCUMENT_DET_BORD updatedDocumentDetBord);
    Task DeleteTj_document(TJ_DOCUMENT_DET_BORD Tj_document);
}