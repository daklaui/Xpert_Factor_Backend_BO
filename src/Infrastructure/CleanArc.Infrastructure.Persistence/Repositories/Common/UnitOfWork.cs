using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.Contrat.Queries.GetAllContrats;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
    private readonly GetAllContratsQueryHandler _contractDetailsQueryHandler;
       
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    
    public IContratRepository ContratRepository { get; }
    public IFraisDiversRepository FraisDiversRepository { get; }
    public ITjcirRepository tjcirRepository { get; }
    public IFraisPaiementRepository FraisPaiementRepository { get; }
    public IFactoringCommissionRepository FactoringCommissionRepository { get; }
    public IContactRepository contactRepository { get; }
    public IRibRepository ribRepository { get; }
    public IAdhAuthRepository adhAuthRepository { get; }
    public IDemandeLimiteRepository DemandeLimiteRepository { get; }
    public IIntFinanceRepository IntFinanceRepository { get; }
    public IDetAssRepository DetAssRepository { get; }
    public IFondGarantieRepository FondGarantieRepository { get; }
    

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        UserRefreshTokenRepository = new UserRefreshTokenRepository(_db);
        OrderRepository = new OrderRepository(_db);
        OrderRepository= new OrderRepository(_db);
        IndividualRepository= new IndividuRepository(_db);
        ContratRepository = new ContratRepository(_db, _contractDetailsQueryHandler);
        FraisDiversRepository = new FraisDiversRepository(_db);
        tjcirRepository = new TJcirRepository(_db);
        FactoringCommissionRepository = new FactoringCommissionRepository(_db);
        contactRepository = new ContactRepository(_db);
        ribRepository = new RibRepository(_db);
        adhAuthRepository = new AdhAuthRepository(_db);
        FraisPaiementRepository = new FraisPaiementRepository(_db);
        DemandeLimiteRepository = new DemandeLimiteRepository(_db);
        IntFinanceRepository = new IntFinanceRepository(_db);
        DetAssRepository = new DetAssRepository(_db);
        FondGarantieRepository = new FondGarantieRepository(_db);
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