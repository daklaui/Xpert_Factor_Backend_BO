namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public IContactRepository contactRepository { get; }
    public IRibRepository ribRepository { get; }
    public IAdhAuthRepository adhAuthRepository { get; }
    
    public ITjcirRepository tjcirRepository { get; }
    
 
    Task CommitAsync();
    ValueTask RollBackAsync();
}