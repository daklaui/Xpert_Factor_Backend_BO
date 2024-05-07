using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Commands.AddValsCommand;

public record AddTListValCommand(Domain.Entities.TR_LIST_VAL listVal) : IRequest<OperationResult<bool>>;

