using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Litige.Commands.AddLitige;

public class AddLitigeCommand_Handler : IRequestHandler<AddLitigesCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddLitigeCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddLitigesCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.LitigesRepository.AddLitigeAsync(request.litige,request.MONT_LT);
        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}

