using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TsUserAuth.Commands.AddTS_USERCommand
{
    public record AddUserCommand(TS_USER User) : IRequest<OperationResult<bool>>; 
}
