using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Limite.Queries;

public record getListOfDemLimitNoActifQuery(PaginationParams paginationParams) : IRequest<OperationResult<PageInfo<getListOfDemLimitNoActif_Response>>>;
