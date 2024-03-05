using CleanArc.Application.Common;
using CleanArc.Application.Features.ListVals.Commands.UpdateTListValCommand;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface ITListValRepository 
    {
        Task<TRListVals> AddTListValAsync(TRListVals tListVal);
        Task<PagedList<TRListVals>> GetAllTListValsAsync(PaginationParams paginationParams);
        Task<TRListVals> GetTListValById(int id);
        Task<TRListVals> UpdateTListValAsync(int id, TRListVals updatedTListVal);
    }
}
