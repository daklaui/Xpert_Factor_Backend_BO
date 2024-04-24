using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.FactoringCommission.Queries.GetAllFactoringCommissions
{
    public record GetAllFactoringCommissionsQuery(PaginationParams paginationParams) : IRequest<OperationResult<PageInfo<GetAllFactoringCommissionsQueryResult>>>;
}