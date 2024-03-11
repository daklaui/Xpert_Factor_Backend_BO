using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TMM.Commands.AddTmmCommand;

public record AddTmmCommand(TR_TMM trTmm) : IRequest<OperationResult<bool>>;
