using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Queries.GetById;

public record GetByIdQuery(PksBordereauxDto BordereauxId) : IRequest<OperationResult<GetByIdQueryResult>>;