namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public ITMMRepository TmmRepository { get; }
    
    public IFinancementRepository FinancementRepository { get; }

    public IContactRepository contactRepository { get; }
    public IRibRepository ribRepository { get; }
    public IAdhAuthRepository adhAuthRepository { get; }
    public  IimpayeRepository ImpayeRepository { get; }
    public ICreditRepository CreditRepository { get; }
    public IDebitRepository DebitRepository { get; }
    public IExtraitRepository ExtraitRepository { get; }
    Task CommitAsync();
    ValueTask RollBackAsync();
}