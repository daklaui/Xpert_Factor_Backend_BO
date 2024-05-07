using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Commands.UpdateTListValCommand;

public record UpdateTListValCommand(TR_LIST_VAL listVal) : IRequest<OperationResult<bool>>;
    

 
