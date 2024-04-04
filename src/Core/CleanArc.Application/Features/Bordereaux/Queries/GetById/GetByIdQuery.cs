using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Queries.GetById;

public record GetByIdQuery(string BordereauxId) :IRequest<OperationResult<GetByIdQueryResult>>;