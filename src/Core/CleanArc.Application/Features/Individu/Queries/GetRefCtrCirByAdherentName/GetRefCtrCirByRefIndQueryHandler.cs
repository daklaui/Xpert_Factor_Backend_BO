using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetRefCtrCirByAdherentName;

internal class GetRefCtrCirByRefIndQueryHandler : IRequestHandler<GetRefCtrCirByRefIndQuery, OperationResult<List<int>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetRefCtrCirByRefIndQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
  
    public async ValueTask<OperationResult<List<int>>> Handle(GetRefCtrCirByRefIndQuery request, CancellationToken cancellationToken)
    {
        var refCtrCirList = await _unitOfWork.IndividualRepository.GetRefCtrCirByRefIndAsync(request.refInd);

        if (refCtrCirList == null || !refCtrCirList.Any())
        {
            return OperationResult<List<int>>.FailureResult("No REF_CTR_CIR found for the given adherent name.");
        }

        return OperationResult<List<int>>.SuccessResult(refCtrCirList);
    }
}
    
