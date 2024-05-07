using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using System.Threading.Tasks;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface ITPostalCodesRepository
    {
        Task<TR_CP> AddTPostalCodesAsync(TR_CP trCp);
        Task<PagedList<TR_CP>> GetAllTPostalCodesAsync(PaginationParams paginationParams);
        Task<TR_CP> GetTPostalCodesById(int id);
        Task<TR_CP> UpdateTPostalCodesAsync(int id, TR_CP updatedTPostalCodes);
    }
}