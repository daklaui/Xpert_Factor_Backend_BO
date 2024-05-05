using CleanArc.Application.Contracts.Persistence;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
       
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
    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        UserRefreshTokenRepository = new UserRefreshTokenRepository(_db);
        OrderRepository= new OrderRepository(_db);
        IndividualRepository= new IndividuRepository(_db);
        LimiteRepository = new LimiteRepository(_db);
        ValuesListRepository = new ValuesListRepository(_db);
        CpRepository = new CpRepository(_db);
       // ActProfRepository = new ActProfRepository(_db);
        LitigesRepository = new LitigesRepository(_db);
        ProrogationsRepository = new ProrogationsRepository(_db);
       // ResolustionLitigeRepository = new ResolutionLitigeRepository(_db);

    }

    public  Task CommitAsync()
    {
        return _db.SaveChangesAsync();
    }

    public ValueTask RollBackAsync()
    {
        return _db.DisposeAsync();
    }
}
