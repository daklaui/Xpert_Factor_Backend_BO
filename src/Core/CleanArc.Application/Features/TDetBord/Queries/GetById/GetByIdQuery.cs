using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Queries.GetById;

public record GetByIdQuery(string TDetBordId) :IRequest<OperationResult<GetByIdQueryResult>>;