using CleanArc.Application.Common;
using CleanArc.Application.Features.Individu.Queries.GetAllIndividus;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.RIB.Queries.GetAllRibsByIndividuQueries;

public record GetAllRibsByIndividuQuery
    (int refIndRib, PaginationParams PaginationParams) : IRequest<
        OperationResult<PageInfo<GetAllRibsByIndividuQueryResult>>>;
