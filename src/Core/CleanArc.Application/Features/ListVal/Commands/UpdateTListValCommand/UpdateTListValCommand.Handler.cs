using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Commands.UpdateTListValCommand;

public class UpdateTListValCommandHandler : IRequestHandler<UpdateTListValCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateTListValCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


   

    public async ValueTask<OperationResult<bool>> Handle(UpdateTListValCommand request,
        CancellationToken cancellationToken)
    {
        var existingListVal = await _unitOfWork.ListValRepository.GetTListValById(request.listVal.ID_LIST_VAL);

        if (existingListVal == null)
        {
            return OperationResult<bool>.FailureResult($"Individu with id {request.listVal.ID_LIST_VAL} not found.");
        }

        await _unitOfWork.ListValRepository.UpdateTListValAsync(existingListVal.ID_LIST_VAL, request.listVal);
        await _unitOfWork.CommitAsync();
        return OperationResult<bool>.SuccessResult(true);
    }
}