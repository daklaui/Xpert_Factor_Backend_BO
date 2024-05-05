using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Commands.AddListVal;

public record AddListValCommand(TR_LIST_VAL ListVal) : IRequest<OperationResult<bool>>;
