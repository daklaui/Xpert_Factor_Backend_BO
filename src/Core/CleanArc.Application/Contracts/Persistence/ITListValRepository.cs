using CleanArc.Application.Common;
using CleanArc.Application.Features.ListVals.Commands.UpdateTListValCommand;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface ITListValRepository 
    {
        Task<ListVals> AddTListValAsync(ListVals tListVal);
        Task<PagedList<ListVals>> GetAllTListValsAsync(PaginationParams paginationParams);
        Task<ListVals> GetTListValById(int id);
        Task<ListVals> UpdateTListValAsync(int id, ListVals updatedTListVal);
    }
}
