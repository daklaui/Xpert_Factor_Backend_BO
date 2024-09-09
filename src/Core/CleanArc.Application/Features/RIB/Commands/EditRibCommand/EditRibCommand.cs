using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities.DTO;
using Mediator;

namespace CleanArc.Application.Features.RIB.Commands.EditRibIndividuCommand;

public record EditRibCommand(TR_RIB rib) : IRequest<OperationResult<bool>>;


