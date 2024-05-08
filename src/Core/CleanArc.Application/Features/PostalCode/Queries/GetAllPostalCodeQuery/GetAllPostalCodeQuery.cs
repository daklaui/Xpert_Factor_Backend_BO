using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.PostalCode.Queries.GetAllPostalCodeQuery;

public record GetAllPostalCodeQuery
    (PaginationParams PaginationParams) : IRequest<OperationResult<PageInfo<GetAllPostalCodeQuery_Response>>>;
