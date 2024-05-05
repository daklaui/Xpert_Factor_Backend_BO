using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using CleanArc.Application.Common;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class TJobsRepository : BaseAsyncRepository<TR_ACTPROF_BCT>, ITJobsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TJobsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PagedList<TR_ACTPROF_BCT>> GetAllTJobsAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            return await PagedList<TR_ACTPROF_BCT>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        }

        public async Task<TR_ACTPROF_BCT> AddTJobsAsync(TR_ACTPROF_BCT actprofBct)
        {
            if (actprofBct == null)
            {
                throw new ArgumentNullException(nameof(actprofBct), "Cannot add a null entity");
            }

            await base.AddAsync(actprofBct);
            return actprofBct;
        }

        public async Task<TR_ACTPROF_BCT> GetTJobsById(int id)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<TR_ACTPROF_BCT> UpdateTJobsAsync(int id, TR_ACTPROF_BCT updatedTJobs)
        {
            var tJobs = await _dbContext.Set<TR_ACTPROF_BCT>().FirstOrDefaultAsync(e => e.Id == id);

            if (tJobs == null)
            {
                throw new InvalidOperationException($"TJobs with id {id} not found");
            }

            tJobs.Code_Section = updatedTJobs.Code_Section;
            tJobs.Section = updatedTJobs.Section;
            tJobs.Code_SousSection = updatedTJobs.Code_SousSection;
            tJobs.SousSection = updatedTJobs.SousSection;
            tJobs.Code_Activite = updatedTJobs.Code_Activite;
            tJobs.Code_Classe = updatedTJobs.Code_Classe;
            tJobs.Classe = updatedTJobs.Classe;
            tJobs.Code_Classe1 = updatedTJobs.Code_Classe1;
            tJobs.Code_SousClasse = updatedTJobs.Code_SousClasse;
            tJobs.SousClasse = updatedTJobs.SousClasse;
            tJobs.ModifiedDate = DateTime.Now;

            await _dbContext.SaveChangesAsync();

            return tJobs;
        }
    }
}
