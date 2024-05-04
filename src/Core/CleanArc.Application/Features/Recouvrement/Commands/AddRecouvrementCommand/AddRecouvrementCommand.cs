using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Recouvrement.Commands;

public record AddRecouvrementCommand(TR_LIST_VAL Recouvrement) : IRequest<OperationResult<bool>>;