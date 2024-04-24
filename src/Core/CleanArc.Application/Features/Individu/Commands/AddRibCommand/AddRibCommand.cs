using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Individu.Commands.AddRibCommand;

public record AddRibCommand(List<TR_RIB> contacts) : IRequest<OperationResult<bool>>;