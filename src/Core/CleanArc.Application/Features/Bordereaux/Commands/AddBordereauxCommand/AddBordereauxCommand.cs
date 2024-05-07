using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.AddBordereauxCommand;

public record AddBordereauxCommand(BordereauDTO Bordereau): IRequest<OperationResult<bool>>;