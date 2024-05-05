namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public ILimiteRepository LimiteRepository { get; }
    public IValuesListRepository ValuesListRepository { get; }
    public IActProfRepository ActProfRepository { get; }
    public ICpRepository CpRepository { get; }
    public ILitigesRepository LitigesRepository { get; }
    public IProrogationsRepository ProrogationsRepository { get; }
    public IResolustionLitigeRepository ResolustionLitigeRepository { get; }
    Task CommitAsync();
    ValueTask RollBackAsync();
}