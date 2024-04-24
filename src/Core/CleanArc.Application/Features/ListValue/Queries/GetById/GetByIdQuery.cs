using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListValue.Queries.GetById
{
    public record GetByIdListValueQuery(int ListValueId) : IRequest<OperationResult<GetByIdListValueQueryResult>>;
}
