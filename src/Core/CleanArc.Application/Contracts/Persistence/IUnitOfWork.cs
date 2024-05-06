using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;

namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    IOrderRepository OrderRepository { get; }
    IIndividualRepository IndividualRepository { get; }
    IContactRepository ContactRepository { get; } 
    IRoleRepository RoleRepository { get; }
    IRolesRepository RolesRepository { get; }
    IRibRepository RibRepository { get; }  
    IUserRoleRepository UserRoleRepository { get; } 
    IPermissionRepository PermissionRepository { get; } 
    IAdhAuthRepository AdhAuthRepository { get; } 
    IUserRepository UserRepository { get; } 

    Task CommitAsync();
    ValueTask RollBackAsync();
}