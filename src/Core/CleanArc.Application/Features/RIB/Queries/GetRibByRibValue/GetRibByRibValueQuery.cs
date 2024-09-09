using CleanArc.Application.Models.Common;
using MediatR;

namespace CleanArc.Application.Features.RIB.Queries.GetRibByRibValue;

public record GetRibByRibValueQuery(string rib):IRequest<OperationResult<GetRibByRibValueQuery_Response>>, global::Mediator.IRequest<OperationResult<GetRibByRibValueQuery_Response>>;
