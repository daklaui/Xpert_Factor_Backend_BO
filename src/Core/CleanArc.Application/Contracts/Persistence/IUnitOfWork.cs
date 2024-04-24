namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public IContactRepository contactRepository { get; }
    public IRibRepository ribRepository { get; }
    public IAdhAuthRepository adhAuthRepository { get; }
    public ITPostalCodesRepository TPostalCodesRepository { get; }
    public ITJobsRepository TJobsRepository { get; }
    public IListValueRepository ListValueRepository { get; }
    public ITR_CPRepository TR_CPRepository { get; }
    public IContratRepository ContratRepository { get; }
    public IFraisDiversRepository FraisDiversRepository { get; }
    public IFactoringCommissionRepository FactoringCommissionRepository { get; }
    public ITjcirRepository tjcirRepository { get; }
    Task CommitAsync();
    ValueTask RollBackAsync();
}