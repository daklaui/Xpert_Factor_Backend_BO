using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using System.Threading.Tasks;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IPostalCodesRepository
    {
        Task AddTPostalCodesAsync(TR_CP trCp);
        Task<PagedList<TR_CP>> GetAllTPostalCodesAsync(PaginationParams paginationParams);
        Task<TR_CP> GetTPostalCodesById(int id);
        Task<bool> UpdateTPostalCodesAsync(int id, TR_CP updatedPostalCode);
    }
}