using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.RecouvrementList.Queries.GetAllFacturesEchu;

public record GetAllFacturesEchuQuery
    (PaginationParams paginationParams) : IRequest<OperationResult<PageInfo<GetAllFacturesEchuQuery_Response>>>;