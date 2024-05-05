using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.RecouvrementList.Queries.GetAllfacturesNonEchu;

public record GetAllFacturesNonEchuQuery(PaginationParams paginationParams) :  IRequest<OperationResult<PageInfo<GetAllFacturesNonEchuQuery_Response>>>;