using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Queries.GetDetailsBordByRefCtr;

public record GetDetailsBordByRefCtrQuery(int RefCtr) : IRequest<OperationResult<List<PksBordereauxDto>>>;