using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Financement.Queries;

public record GetFinancementByIdQuery(int id) : IRequest<OperationResult<GetFinancementByIdQueryResult>>;
