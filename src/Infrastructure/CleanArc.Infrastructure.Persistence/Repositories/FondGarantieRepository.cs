using System;
using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class FondGarantieRepository : BaseAsyncRepository<T_FOND_GARANTIE>, IFondGarantieRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public FondGarantieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddFondGarantieAsync(T_FOND_GARANTIE fondGarantie)
        {
            await base.AddAsync(fondGarantie);
        }

        public async Task<PagedList<T_FOND_GARANTIE>> GetAllFondsGarantieAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<T_FOND_GARANTIE>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
            return result;
        }

        public async Task<List<T_FOND_GARANTIE>> GetFondGarantieById(int id)
        {
            return await base.TableNoTracking.Where(p => p.REF_CTR_FDG == id).ToListAsync();
        }

        public async Task<T_FOND_GARANTIE> GetFondGarantieByRefCtrAndType(int id, string type)
        {
            return await base.TableNoTracking.FirstAsync(p => p.REF_CTR_FDG == id && p.TYP_FDG == type);
        }

        public async Task<bool> UpdateFondGarantieAsync(int fondGarantieId, T_FOND_GARANTIE updatedFondGarantie)
        {
            var existingFondGarantie = await base.Table.FirstOrDefaultAsync(p => p.REF_CTR_FDG == fondGarantieId);

            if (existingFondGarantie == null)
            {
                throw new InvalidOperationException($"Fond Garantie with Id {fondGarantieId} not found");
            }

            existingFondGarantie.TYP_FDG = updatedFondGarantie.TYP_FDG;
            existingFondGarantie.LIB_FDG = updatedFondGarantie.LIB_FDG;
            existingFondGarantie.TX_FDG = updatedFondGarantie.TX_FDG;
            existingFondGarantie.MONT_MAX_FDG = updatedFondGarantie.MONT_MAX_FDG;
            existingFondGarantie.MONT_MIN_FDG = updatedFondGarantie.MONT_MIN_FDG;
            existingFondGarantie.TYP_DOC_REMIS_FDG = updatedFondGarantie.TYP_DOC_REMIS_FDG;

            await base.UpdateAsync(existingFondGarantie);

            return true;
        }

    }
}
