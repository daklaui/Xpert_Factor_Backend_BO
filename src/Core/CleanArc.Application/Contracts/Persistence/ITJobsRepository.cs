using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface ITJobsRepository
    {
        Task<TJobs> AddTJobsAsync(TJobs tJobs);
        Task<PagedList<TJobs>> GetAllTJobsAsync(PaginationParams paginationParams);
        Task<TJobs> GetTJobsById(int id);
        Task<TJobs> UpdateTJobsAsync(int id, TJobs updatedTJobs);
    }
}
