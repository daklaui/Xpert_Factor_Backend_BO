namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public ITMMRepository TmmRepository { get; }
    public IFinancementRepository FinancementRepository { get; }

    Task CommitAsync();
    ValueTask RollBackAsync();
}