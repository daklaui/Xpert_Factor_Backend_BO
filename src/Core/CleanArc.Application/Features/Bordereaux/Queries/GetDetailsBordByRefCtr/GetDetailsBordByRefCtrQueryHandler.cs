using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Queries.GetDetailsBordByRefCtr;

internal class GetDetailsBordByRefCtrQueryHandler : IRequestHandler<GetDetailsBordByRefCtrQuery, OperationResult<List<BordereauxWithIndividuDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetDetailsBordByRefCtrQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async ValueTask<OperationResult<List<BordereauxWithIndividuDto>>> Handle(GetDetailsBordByRefCtrQuery request, CancellationToken cancellationToken)
    {
        var bordereauDetails = await _unitOfWork.BordereauxRepository.GetDetailsBordByRefCtrAsync(request.RefCtr);

        if (bordereauDetails == null || !bordereauDetails.Any())
        {
            return OperationResult<List<BordereauxWithIndividuDto>>.FailureResult("No bordereau details found for the given reference.");
        }

        return OperationResult<List<BordereauxWithIndividuDto>>.SuccessResult(bordereauDetails);
    }
}