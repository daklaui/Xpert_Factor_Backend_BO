using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using System.Threading.Tasks;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface ITS_USERRepository
    {
        Task AddTS_USERAsync(TS_USER ts_user);
        Task<PagedList<TS_USER>> GetAllTS_USERSAsync(PaginationParams paginationParams);
        Task<TS_USER> GetTS_USERById(int id);
        //Task<bool> UpdateTS_USERAsync(int id, TS_USER updatedTS_USER);
    }
}