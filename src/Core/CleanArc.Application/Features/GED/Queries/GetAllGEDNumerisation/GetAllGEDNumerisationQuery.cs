using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.GED.Queries;

public record GetAllGEDNumerisationQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetAllGEDNumerisationQueryResult>>>;