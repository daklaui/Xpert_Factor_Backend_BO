namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public IPostalCodesRepository PostalCodesRepository { get; }
    public IGEDRepository GEDRepository { get; }
    public ITMMRepository TmmRepository { get; }
    public IFundingRepository FundingRepository { get; }
    public IContactRepository contactRepository { get; }
    public IRibRepository ribRepository { get; }
    public IAdhAuthRepository adhAuthRepository { get; }
    public ITjcirRepository tjcirRepository { get; }
    public  IimpayeRepository ImpayeRepository { get; }
    public ICreditRepository CreditRepository { get; }
    public IDebitRepository DebitRepository { get; }
    public IExtraitRepository ExtraitRepository { get; }
    public IAgencyBankRepository AgencyBankRepository { get; }
    public  IEncaissement EncaissementRepository { get; }
    public ILimiteRepository LimiteRepository { get; }
    public  IListValRepository ListValRepository { get; }
    public  IProrogationsRepository ProrogationsRepository { get; }
    public ILitigesRepository LitigesRepository { get; }
    public IRecouvrementRepository RecouvrementRepository { get; }
    public ITJobsRepository TJobsRepository { get; }
    public IContratRepository ContratRepository { get; }
    public IFraisDiversRepository FraisDiversRepository { get; }
    public IFactoringCommissionRepository FactoringCommissionRepository { get; }
    public IFraisPaiementRepository FraisPaiementRepository { get; }
    public IIntFinanceRepository IntFinanceRepository { get; }
    public IDetAssRepository DetAssRepository { get; }
    public IFondGarantieRepository FondGarantieRepository { get; }
    public IT_DET_BORD_Repository TDetBordRepository { get; }
    ITJ_DOCUMENT_DET_BORD_Repository TjDocumentDetBordRepository { get; }
    public IBordereauxRepository BordereauxRepository { get; }
    Task CommitAsync();
    ValueTask RollBackAsync();
}