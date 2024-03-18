using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Limite.Commands.AddLimiteCommand;

public class AddLimiteCommand_Handler:IRequestHandler<AddLimiteCommand, OperationResult<bool>>
{
    public AddLimiteCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    private readonly IUnitOfWork _unitOfWork;
    
    public async ValueTask<OperationResult<bool>> Handle(AddLimiteCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.LimiteRepository.AddTDemLimitesync(request.Limite);
        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}