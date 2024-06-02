using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Limite.Queries.GetAllListOfDemLimitNoActif;

public record GetAllListOfDemLimitNoActifQuery(PaginationParams paginationParams):IRequest<OperationResult<PageInfo<GetAllListOfDemLimitNoActifQuery_Response>>>;

