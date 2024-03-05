using CleanArc.Application.Features.TMM.Queries.GetAllTmmQueries;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TMM.Queries.GetTmmByIdQueries;

public record GetTmmByIdQuery(int Tmmid) : IRequest<OperationResult<GetTmmByIdQueryResult>>;
