using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListValue.Queries.GetAllListValues
{
    public record GetAllListValuesQuery(PaginationParams paginationParams) : IRequest<OperationResult<PageInfo<GetAllListValuesQueryResult>>>;
}
