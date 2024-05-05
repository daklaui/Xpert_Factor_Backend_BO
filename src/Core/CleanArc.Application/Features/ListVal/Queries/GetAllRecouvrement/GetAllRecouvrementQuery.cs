using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Queries.GetAllRecouvrement;

public record GetAllRecouvrementQuery (PaginationParams paginationParams) : IRequest<OperationResult<PageInfo<GetAllRecouvrementQuery_Response>>>;
