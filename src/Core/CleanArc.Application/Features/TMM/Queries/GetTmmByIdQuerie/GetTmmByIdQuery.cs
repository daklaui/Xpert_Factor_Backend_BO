using CleanArc.Application.Features.Individu.Queries.GetByIdQuery;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TMM.Queries.GetTmmByIdQuerie;

public record GetTmmByIdQuery(int idTmm) :  IRequest<OperationResult<GetTmmByIdQueryResult>>;
