using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Financement.Queries;

public record GetFundingByIdQuery(int id) : IRequest<OperationResult<GetFinancementByIdQueryResult>>;
