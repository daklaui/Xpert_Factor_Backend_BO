using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.PostalCode.Queries.GetByIdPostalCodeQuery;

public record GetByIdPostalCodeQuery(int id) : IRequest<OperationResult<GetByIdPostalCodeQuery_Response>>;
