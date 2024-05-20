using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetRefCtrCirByAdherentName;

public record GetRefCtrCirByRefIndQuery(int refInd) : IRequest<OperationResult<List<int>>>;