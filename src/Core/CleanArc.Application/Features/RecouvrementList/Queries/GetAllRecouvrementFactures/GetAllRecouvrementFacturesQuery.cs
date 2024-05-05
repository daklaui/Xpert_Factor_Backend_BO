using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.RecouvrementList.Queries.GetAllRecouvrement;

public record GetAllRecouvrementFacturesQuery
    (PaginationParams paginationParams) : IRequest<OperationResult<PageInfo<GetAllRecouvrementFacturesQuery_Response>>>;
