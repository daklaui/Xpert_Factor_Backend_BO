using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Financement.Queries;

public record GetAllFinancementQuery(PaginationParams paginationParams):IRequest<OperationResult<PageInfo<GetAllFinancementQueryResult>>>;
