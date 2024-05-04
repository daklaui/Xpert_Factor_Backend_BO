namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public ITMMRepository TmmRepository { get; }
    
    public IFundingRepository FundingRepository { get; }

    public IContactRepository contactRepository { get; }
    public IRibRepository ribRepository { get; }
    public IAdhAuthRepository adhAuthRepository { get; }
    public  IimpayeRepository ImpayeRepository { get; }
    public ICreditRepository CreditRepository { get; }
    public IDebitRepository DebitRepository { get; }
    public IExtraitRepository ExtraitRepository { get; }
    public IAgencyBankRepository AgencyBankRepository { get; }
    //public ITPostalCodesRepository TPostalCodesRepository { get; }
   // public ITJobsRepository TJobsRepository { get; } // Nouvelle propriété

    
    public  IEncaissement EncaissementRepository { get; }
    public ILimiteRepository LimiteRepository { get; }
    Task CommitAsync();
    ValueTask RollBackAsync();
}