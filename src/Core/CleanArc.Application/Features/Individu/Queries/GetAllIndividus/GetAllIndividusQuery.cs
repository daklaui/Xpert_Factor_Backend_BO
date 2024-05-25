using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllIndividus;

public record GetAllIndividusQuery(PaginationParams paginationParams) : IRequest<OperationResult<PageInfo<GetAllIndividusQueryResult>>>;