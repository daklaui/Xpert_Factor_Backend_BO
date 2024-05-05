using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using CleanArc.Infrastructure.Persistence.Repositories.Common;
using System.Web;
namespace CleanArc.Infrastructure.Persistence.Repositories;

public class ListValRepository:BaseAsyncRepository<TR_LIST_VAL>,IListValRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ListValRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<TR_LIST_VAL>> GetAllRecouvrementAsync()
    {
        var listVal =  _dbContext.TR_LIST_VALs
            .Where(p => p.TYP_LIST_VAL == "COMM_RECOUV")
            .Select(p => new TR_LIST_VAL { LIB_LIST_VAL = p.LIB_LIST_VAL })
            .ToList();

        return listVal;
    }
}