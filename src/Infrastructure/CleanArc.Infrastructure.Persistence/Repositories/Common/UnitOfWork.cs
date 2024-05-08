using CleanArc.Application.Contracts.Persistence;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
    private IUnitOfWork _unitOfWorkImplementation;


    public ITPostalCodesRepository TPostalCodesRepository { get; } 
    
    public ITR_CPRepository TR_CPRepository { get; }
    public IContratRepository ContratRepository { get; }
    public IFraisDiversRepository FraisDiversRepository { get; }
    public IFactoringCommissionRepository FactoringCommissionRepository { get; }
    public IFraisPaiementRepository FraisPaiementRepository { get; }

    public IListValRepository ListValueRepository { get; }
    
    public IFactoringCommissionRepository FactoringCommis { get; }
    public IIntFinanceRepository IntFinanceRepository { get; }
    public IDetAssRepository DetAssRepository { get; }
    public IFondGarantieRepository FondGarantieRepository { get; } 
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IGEDRepository GEDRepository { get; }

    public IIndividualRepository IndividualRepository { get; }
    public ITMMRepository TmmRepository { get; }
    public IFundingRepository FundingRepository { get; }
    public IContactRepository contactRepository { get; }
    public IRibRepository ribRepository { get; }
    public IAdhAuthRepository adhAuthRepository { get; }
    public ITjcirRepository tjcirRepository { get; }
    public IimpayeRepository ImpayeRepository { get; }
    public ICreditRepository CreditRepository { get; }
    public IDebitRepository DebitRepository { get; }
    public IExtraitRepository ExtraitRepository { get; }
    public IAgencyBankRepository AgencyBankRepository { get; }
    public IEncaissement EncaissementRepository { get; }
    
    public ITjcirRepository  JcirRepository{ get; set; }
    public ILimiteRepository LimiteRepository { get; }
    public IListValRepository ListValRepository { get; }
    public IProrogationsRepository ProrogationsRepository { get; }
    public ILitigesRepository LitigesRepository { get; }
    
    public IRecouvrementRepository RecouvrementRepository { get; }
    public ITJobsRepository TJobsRepository { get; }

    
    public IT_DET_BORD_Repository TDetBordRepository { get; }
    public ITJ_DOCUMENT_DET_BORD_Repository TjDocumentDetBordRepository { get; }
    public IBordereauxRepository BordereauxRepository { get; }
    public UnitOfWork(ApplicationDbContext db )
    {
        _db = db;
        JcirRepository = new TJcirRepository(_db);
        UserRefreshTokenRepository = new UserRefreshTokenRepository(_db);
        OrderRepository = new OrderRepository(_db);
        IndividualRepository = new IndividuRepository(_db);
        TmmRepository = new TmmRepository(_db);
        FundingRepository = new FundingRepository(_db);
        contactRepository = new ContactRepository(_db);
        ribRepository = new RibRepository(_db);
        ContratRepository = new ContratRepository(_db);
        ImpayeRepository =new ImpayeRepository(_db);
        DebitRepository =new DebitRepository(_db);
        ExtraitRepository = new ExtraitRepository(_db);
        AgencyBankRepository = new AgencyBankRepositoryRepository(_db);
        OrderRepository = new OrderRepository(_db);
        IndividualRepository = new IndividuRepository(_db);
        EncaissementRepository = new EncaissementReposiotry(_db);
        OrderRepository= new OrderRepository(_db);
        IndividualRepository= new IndividuRepository(_db);
        LimiteRepository = new LimiteRepository(_db);
        ListValRepository = new ListValRepository(_db);
        ProrogationsRepository = new ProrogationsRepository(_db);
        LitigesRepository = new LitigesRepository(_db);
        GEDRepository = new GEDRepository(_db);
        RecouvrementRepository = new RecouvrementRepository(_db);
        OrderRepository= new OrderRepository(_db);
        IndividualRepository= new IndividuRepository(_db);
        BordereauxRepository = new BordereauxRepository(_db);
        TjDocumentDetBordRepository = new TJ_DOCUMENT_DET_BORD_Repository(_db);
        TDetBordRepository = new TDetBordRepository(_db);
        tjcirRepository = new TJcirRepository(_db);
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
