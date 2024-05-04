using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Impaye.Queries;

public record GetListOfImpayeQuery(PaginationParams PaginationParams) : IRequest<OperationResult<PageInfo<GetListOfImpayeQuery_Response>>>;
