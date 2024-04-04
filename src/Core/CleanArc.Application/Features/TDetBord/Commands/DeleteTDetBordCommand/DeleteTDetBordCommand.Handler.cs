using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Commands.DeleteTDetBordCommand;

public class DeleteTDetBordCommandHandler : IRequestHandler<DeleteTDetBordCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteTDetBordCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async ValueTask<OperationResult<bool>> Handle(DeleteTDetBordCommand request, CancellationToken cancellationToken)
    {
        var TDetBordToDelete = await _unitOfWork.TDetBordRepository.GetT_DET_BORD_Byid(request.TDetBordId);

        if (TDetBordToDelete != null)
        {
            _unitOfWork.TDetBordRepository.DeleteT_DET_BORD(TDetBordToDelete);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
        else
        {
            return OperationResult<bool>.NotFoundResult("Bordereau not found.");
        }
    }
}