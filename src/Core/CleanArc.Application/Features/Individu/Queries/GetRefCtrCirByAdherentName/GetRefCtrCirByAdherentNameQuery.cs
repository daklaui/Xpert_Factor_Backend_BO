using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetRefCtrCirByAdherentName;

public record GetRefCtrCirByAdherentNameQuery(int  refInd) : IRequest<OperationResult<List<int>>>;