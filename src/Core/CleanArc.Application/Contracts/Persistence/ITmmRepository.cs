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
        Task<TRTMM> GetTmmByIdAsync(int id);
        Task<PagedList<TRTMM>> GetAllTmmAsync(PaginationParams paginationParams);
        Task AddTmmAsync(TRTMM tmm);
        Task UpdateTmmAsync(TRTMM tmm);
    }
}
