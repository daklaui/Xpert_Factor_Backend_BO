using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Impaye.Queries.GetListeResolutionDesImpayes;

public record GetListeResolutionDesImpayesQuery(PaginationParams PaginationParams) : IRequest<OperationResult<PageInfo<GetListeResolutionDesImpayesQuery_Response>>>;

