using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.FactoringCommission.Queries.GetByIdQuery
{
    public record GetByIdQuery(int factoringCommissionId) : IRequest<OperationResult<GetByIdQueryResult>>;
}