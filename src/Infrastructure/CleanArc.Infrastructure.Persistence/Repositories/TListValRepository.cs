using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Features.ListVals.Commands.UpdateTListValCommand;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class TListValRepository : BaseAsyncRepository<TR_LIST_VAL>, ITListValRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public TListValRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<PagedList<TR_LIST_VAL>> GetAllTListValsAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            return await PagedList<TR_LIST_VAL>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);
        }

        public async Task<TR_LIST_VAL> AddTListValAsync(TR_LIST_VAL listVal)
        {
            if (listVal == null)
            {
                throw new ArgumentNullException(nameof(listVal), "Cannot add a null entity");
            }

            await base.AddAsync(listVal);
            return listVal;
        }


        public async Task<TR_LIST_VAL> GetTListValById(int id)
        {
            return await base.TableNoTracking.FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<TR_LIST_VAL> UpdateTListValAsync(int id, TR_LIST_VAL updatedTListVal)
        {
            var listVal = await _dbContext.Set<TR_LIST_VAL>().FirstOrDefaultAsync(e => e.Id == id);

            if (listVal == null)
            {
                throw new InvalidOperationException($"ListVals with id {id} not found");
            }

            listVal.AbrListVal = updatedTListVal.AbrListVal;
            listVal.TypListVal = updatedTListVal.TypListVal;
            listVal.OrdListVal = updatedTListVal.OrdListVal;
            listVal.LibListVal = updatedTListVal.LibListVal;
            listVal.ComListVal = updatedTListVal.ComListVal;
            listVal.ModifiedDate = DateTime.Now;

            await _dbContext.SaveChangesAsync();

            return listVal;
        }







    }
}