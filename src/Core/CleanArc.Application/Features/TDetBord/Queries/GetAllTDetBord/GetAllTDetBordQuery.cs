using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Queries.GetAllTDetBord;

public record GetAllTDetBordQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetAllTDetBordQueryResult>>>;