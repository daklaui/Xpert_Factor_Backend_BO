using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TPostalCodes.Queries.GetAllTPostalCodes
{
    public record GetAllTPostalCodesQuery(PaginationParams PaginationParams) : IRequest<OperationResult<PageInfo<GetAllTPostalCodesQueryResult>>>;
}
