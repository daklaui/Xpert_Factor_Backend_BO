using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Impaye.Queries.GetListehistorical;

public record GetListeHistoricalQuery(PaginationParams PaginationParams) : IRequest<OperationResult<PageInfo<GetListeHistoricalQuery_Response>>>;
