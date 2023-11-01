 
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllIndividus;

public record GetAllIndividusQuery():IRequest<OperationResult<List<GetAllIndividusQueryResult>>>;