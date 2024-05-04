using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Financement.Queries;

public record GetFundingByRefCtrQuery(int id) : IRequest<OperationResult<GetFinancementRefCtrQueryResult>>;
