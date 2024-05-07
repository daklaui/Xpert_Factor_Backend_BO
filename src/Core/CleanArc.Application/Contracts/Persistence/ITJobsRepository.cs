using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface ITJobsRepository
    {
        Task<TR_ACTPROF_BCT> AddTJobsAsync(TR_ACTPROF_BCT actprofBct);
        Task<PagedList<TR_ACTPROF_BCT>> GetAllTJobsAsync(PaginationParams paginationParams);
        Task<TR_ACTPROF_BCT> GetTJobsById(string id);
        Task<TR_ACTPROF_BCT> UpdateTJobsAsync(string id, TR_ACTPROF_BCT updatedTJobs);
    }
}
