using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Litige.Queries.GetAllLitiges;

public record GetAllLitigesQuery(PaginationParams PaginationParams)
    : IRequest<OperationResult<PageInfo<GetAllLitigesQuery_Response>>>;

