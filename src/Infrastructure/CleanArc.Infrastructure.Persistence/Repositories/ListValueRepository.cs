using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infrastructure.Persistence.Repositories
{
    internal class ListValueRepository : BaseAsyncRepository<TR_LIST_VAL>, IListValueRepository
    {
        public ListValueRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddListValueAsync(TR_LIST_VAL listValue)
        {
            await base.AddAsync(listValue);
        }

        public async Task<PagedList<TR_LIST_VAL>> GetAllListValuesAsync(PaginationParams paginationParams)
        {
            var query = base.TableNoTracking.AsQueryable();
            var result = await PagedList<TR_LIST_VAL>.CreateAsync(query, paginationParams.PageNumber, paginationParams.PageSize);

            return result;
        }

        public async Task<TR_LIST_VAL> GetListValueById(int id)
        {
            return await base.TableNoTracking.FirstAsync(p => p.ID_LIST_VAL == id);
        }

        public async Task<bool> UpdateListValueAsync(int id, TR_LIST_VAL updatedListValue)
        {
            var existingListValue = await base.Table.FirstOrDefaultAsync(e => e.ID_LIST_VAL == id);

            if (existingListValue == null)
            {
                throw new InvalidOperationException($"ListValue with id {id} not found");
            }

            existingListValue.ABR_LIST_VAL = updatedListValue.ABR_LIST_VAL;
            existingListValue.TYP_LIST_VAL = updatedListValue.TYP_LIST_VAL;
            existingListValue.ORD_LIST_VAL = updatedListValue.ORD_LIST_VAL;
            existingListValue.LIB_LIST_VAL = updatedListValue.LIB_LIST_VAL;
            existingListValue.COM_LIST_VAL = updatedListValue.COM_LIST_VAL;
            existingListValue.NB_JOUR_LIST_VAL = updatedListValue.NB_JOUR_LIST_VAL;
            existingListValue.TYPE_RECOUVREMENT = updatedListValue.TYPE_RECOUVREMENT;

            await base.UpdateAsync(existingListValue);

            return true;
        }
    }
}
