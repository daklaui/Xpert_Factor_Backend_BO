using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using System.Threading.Tasks;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface ITPostalCodesRepository
    {
        Task<TPostalCodes> AddTPostalCodesAsync(TPostalCodes tPostalCodes);
        Task<PagedList<TPostalCodes>> GetAllTPostalCodesAsync(PaginationParams paginationParams);
        Task<TPostalCodes> GetTPostalCodesById(int id);
        Task<TPostalCodes> UpdateTPostalCodesAsync(int id, TPostalCodes updatedTPostalCodes);
    }
}