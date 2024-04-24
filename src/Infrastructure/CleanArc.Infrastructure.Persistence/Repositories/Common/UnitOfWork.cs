using CleanArc.Application.Contracts.Persistence;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
       
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public ITPostalCodesRepository TPostalCodesRepository { get; }
    public ITJobsRepository TJobsRepository { get; } 
    
    public ITR_CPRepository TR_CPRepository { get; }
    public IContratRepository ContratRepository { get; }
    public IFraisDiversRepository FraisDiversRepository { get; }
    public IListValueRepository ListValueRepository { get; }
    
    public IFactoringCommissionRepository FactoringCommissionRepository { get; }

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        UserRefreshTokenRepository = new UserRefreshTokenRepository(_db);
        OrderRepository = new OrderRepository(_db);
        TPostalCodesRepository = new TPostalCodesRepository(_db);
        TJobsRepository = new TJobsRepository(_db); 
        OrderRepository= new OrderRepository(_db);
        IndividualRepository= new IndividuRepository(_db);
        ListValueRepository = new ListValueRepository(_db);
        TR_CPRepository = new TR_CPRepository(_db);
        ContratRepository = new ContratRepository(_db);
        FraisDiversRepository = new FraisDiversRepository(_db);
        FactoringCommissionRepository = new FactoringCommissionRepository(_db);
    }

    public Task CommitAsync()
    {
        return _db.SaveChangesAsync();
    }

    public ValueTask RollBackAsync()
    {
        return _db.DisposeAsync();
    }
}