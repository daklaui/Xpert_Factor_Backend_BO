using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Individu.Commands.AddIndividuCommand;

public record AddIndividuCommand(TIndividu Individu) : IRequest<OperationResult<bool>>;