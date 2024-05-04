using CleanArc.Application.Contracts.Persistence;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
       
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }

    public IIndividualRepository IndividualRepository { get; }

    public IContactRepository contactRepository { get; }

    public IRibRepository ribRepository { get; }

    public IAdhAuthRepository adhAuthRepository { get; }
    
    public ICreditRepository CreditRepository { get; }
    public IDebitRepository DebitRepository { get; }

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        UserRefreshTokenRepository = new UserRefreshTokenRepository(_db);
        OrderRepository= new OrderRepository(_db);
        IndividualRepository= new IndividuRepository(_db);
        contactRepository = new ContactRepository(_db);
        ribRepository = new RibRepository(_db);
        adhAuthRepository = new AdhAuthRepository(_db);
        CreditRepository = new CreditRepository(_db);
        DebitRepository = new DebitRepository(_db);
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