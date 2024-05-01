namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public IContactRepository contactRepository { get; }
    public IRibRepository ribRepository { get; }
    public IAdhAuthRepository adhAuthRepository { get; }
    public IContratRepository ContratRepository { get; }
    public IFraisDiversRepository FraisDiversRepository { get; }
    public IFactoringCommissionRepository FactoringCommissionRepository { get; }
    public ITjcirRepository tjcirRepository { get; }
    public IFraisPaiementRepository FraisPaiementRepository { get; }
    public IDemandeLimiteRepository DemandeLimiteRepository { get; }
    public IIntFinanceRepository IntFinanceRepository { get; }
    public IDetAssRepository DetAssRepository { get; }
    public IFondGarantieRepository FondGarantieRepository { get; }
    Task CommitAsync();
    ValueTask RollBackAsync();
}