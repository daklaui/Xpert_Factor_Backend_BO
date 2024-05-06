using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.User; // Assurez-vous d'utiliser le bon namespace pour Permission
using Mediator;

namespace CleanArc.Application.Features.Permissions.Commands.AddPermissionCommand
{
    public record AddPermissionCommand(Permission Permission) : IRequest<OperationResult<bool>>; 
}