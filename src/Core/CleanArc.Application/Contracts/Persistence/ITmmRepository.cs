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
        Task<TTMM> GetTmmByIdAsync(int id);
        Task<PagedList<TTMM>> GetAllTmmAsync(PaginationParams paginationParams);
        Task AddTmmAsync(TTMM tmm);
        Task UpdateTmmAsync(TTMM tmm);
    }
}
