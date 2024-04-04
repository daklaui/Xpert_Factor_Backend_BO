using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Queries.GetAllBordereaux;

public record GetAllBordereauxQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetAllBordereauxQueryResult>>>;