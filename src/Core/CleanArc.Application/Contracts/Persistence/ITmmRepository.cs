using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface ITmmRepository
    {
        Task<TMM> GetTmmByIdAsync(int id);
        Task<PagedList<TMM>> GetAllTmmAsync(PaginationParams paginationParams);
        Task AddTmmAsync(TMM tmm);
        Task UpdateTmmAsync(TMM tmm);
    }
}
