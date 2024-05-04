using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using Mediator;

namespace CleanArc.Application.Features.RIB.Commands.AddRibCommand;

public record AddRibCommand(TR_RIB rib ):IRequest<OperationResult<bool>>;
