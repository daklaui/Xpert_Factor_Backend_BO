using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.GED.Queries.GetAllGEDValidation;

public record GetAllGEDValidationQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetAllGEDValidationQueryResult>>>;