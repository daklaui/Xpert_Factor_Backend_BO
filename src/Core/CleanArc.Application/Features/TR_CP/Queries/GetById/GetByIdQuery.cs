using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TR_CP.Queries.GetById
{
    public record GetByIdQuery(int trCpId) : IRequest<OperationResult<GetByIdQueryResult>>;
}