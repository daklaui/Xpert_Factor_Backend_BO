using CleanArc.Application.Contracts.Persistence;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
    

    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public ITMMRepository TmmRepository { get; }
    public IFundingRepository FundingRepository { get; }
    public IContactRepository contactRepository { get; }
    public IRibRepository ribRepository { get; }
    public IAdhAuthRepository adhAuthRepository { get; }
    public IimpayeRepository ImpayeRepository { get; }
    public ICreditRepository CreditRepository { get; }
    public IDebitRepository DebitRepository { get; }
    public IExtraitRepository ExtraitRepository { get; }
    public IAgencyBankRepository AgencyBankRepository { get; }
    //public ITPostalCodesRepository TPostalCodesRepository { get; }
    //public ITJobsRepository TJobsRepository { get; } // Nouvelle propriété
    public IEncaissement EncaissementRepository { get; }

    
    public ILimiteRepository LimiteRepository { get; }
    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        UserRefreshTokenRepository = new UserRefreshTokenRepository(_db);
        OrderRepository = new OrderRepository(_db);
        IndividualRepository = new IndividuRepository(_db);
        TmmRepository = new TmmRepository(_db);
        FundingRepository = new FundingRepository(_db);
        contactRepository = new ContactRepository(_db);
        ribRepository = new RibRepository(_db);
        adhAuthRepository = new AdhAuthRepository(_db);
        ImpayeRepository =new ImpayeRepository(_db);
        CreditRepository = new CreditRepository(_db);
        DebitRepository =new DebitRepository(_db);
        ExtraitRepository = new ExtraitRepository(_db);
        AgencyBankRepository = new AgencyBankRepositoryRepository(_db);
        OrderRepository = new OrderRepository(_db);
        IndividualRepository = new IndividuRepository(_db);
        //TPostalCodesRepository = new TPostalCodesRepository(_db);
        //TJobsRepository = new TJobsRepository(_db); // Initialisation de TJobsRepository
        EncaissementRepository = new EncaissementReposiotry(_db);
        OrderRepository= new OrderRepository(_db);
        IndividualRepository= new IndividuRepository(_db);
        LimiteRepository = new LimiteRepository(_db);
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
