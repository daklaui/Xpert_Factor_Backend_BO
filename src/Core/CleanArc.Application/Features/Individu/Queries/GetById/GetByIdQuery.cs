 
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetByIdQuery;

public abstract partial record GetByIdQuery(int individuId) :IRequest<OperationResult<GetByIdQueryResult>>;