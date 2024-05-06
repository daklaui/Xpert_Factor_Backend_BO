using CleanArc.Domain.Entities.User;
using Mediator;
using CleanArc.Application.Models.Common;

namespace CleanArc.Application.Features.Roles.Commands.AddRoleCommand
{
    public record AddRoleCommand(ROLES Role) : IRequest<OperationResult<bool>>;
}