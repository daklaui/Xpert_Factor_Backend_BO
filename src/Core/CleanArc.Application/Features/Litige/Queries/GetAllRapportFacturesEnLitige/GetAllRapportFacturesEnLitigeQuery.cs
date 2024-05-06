using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Litige.Queries.GetAllRapportFacturesEnLitige;

public record GetAllRapportFacturesEnLitigeQuery(PaginationParams PaginationParams) : IRequest<OperationResult<PageInfo<GetAllRapportFacturesEnLitigeQuery_Response>>>;

