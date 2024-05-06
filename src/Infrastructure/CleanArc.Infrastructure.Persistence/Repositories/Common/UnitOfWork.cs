using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
       
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public IContactRepository ContactRepository { get; } 
    public IRoleRepository RoleRepository { get; }
    public IRolesRepository RolesRepository { get; }
    public IRibRepository RibRepository { get; }
    public IUserRoleRepository UserRoleRepository { get; }
    public IPermissionRepository PermissionRepository { get; }
    public IAdhAuthRepository AdhAuthRepository { get; }
    public IUserRepository UserRepository { get; } // Add this line

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        UserRefreshTokenRepository = new UserRefreshTokenRepository(_db);
        OrderRepository = new OrderRepository(_db);
        IndividualRepository = new IndividuRepository(_db);
        ContactRepository = new ContactRepository(_db); // Ensure proper naming convention
        RibRepository = new RibRepository(_db);
        AdhAuthRepository = new AdhAuthRepository(_db);
        UserRepository = new UserRepository(_db);
        RolesRepository = new RolesRepository(_db);
    }

    public Task CommitAsync()
    {
        return _db.SaveChangesAsync();
    }

    public ValueTask RollBackAsync()
    {
        return _db.DisposeAsync();
    }
}