namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public ITmmRepository TmmRepository { get; }
    public IAgBqRepository AgBqRepository { get; }

    Task CommitAsync();
    ValueTask RollBackAsync();
}