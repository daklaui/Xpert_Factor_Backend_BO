﻿using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IFraisDiversRepository
    {
        Task AddFraisDiversAsync(T_FRAIS_DIVERS fraisDivers);
        Task<PagedList<T_FRAIS_DIVERS>> GetAllFraisDiversAsync(PaginationParams paginationParams);
        Task<T_FRAIS_DIVERS> GetFraisDiversById(int id);
        Task<bool> UpdateFraisDiversAsync(int id, T_FRAIS_DIVERS updatedFraisDivers);
    }
}