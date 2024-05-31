using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Queries.GetListValByType
{
    public record GetListValByTypeQuery(string type) : IRequest<OperationResult<List<GetListValByTypeQueryResult>>>;
}