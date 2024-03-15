using CleanArc.Application.Contracts.Persistence;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
       
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }

    public IIndividualRepository IndividualRepository { get; }
    
    public ITMMRepository TmmRepository { get; }
  
    public IFinancementRepository FinancementRepository { get; }
   
    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        UserRefreshTokenRepository = new UserRefreshTokenRepository(_db);
        OrderRepository= new OrderRepository(_db);
        IndividualRepository= new IndividuRepository(_db);
        TmmRepository = new TmmRepository(_db);
        FinancementRepository = new FinancementRepository(_db);
    }

    public  Task CommitAsync()
    {
        return _db.SaveChangesAsync();
    }

    public ValueTask RollBackAsync()
    {
        return _db.DisposeAsync();
    }
}