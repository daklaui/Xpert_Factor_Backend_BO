using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Queries.GetTListValById
{
    public record GetTListValByIdQuery(int tListValId) : IRequest<OperationResult<GetByIdQueryResult>>;
}
