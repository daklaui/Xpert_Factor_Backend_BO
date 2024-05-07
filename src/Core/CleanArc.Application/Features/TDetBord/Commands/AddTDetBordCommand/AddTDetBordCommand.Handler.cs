using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Commands.AddTDetBordCommand;

public class AddTDetBordCommandHandler : IRequestHandler<AddTDetBordCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAppUserManager _userManager;

    public AddTDetBordCommandHandler(IUnitOfWork unitOfWork, IAppUserManager userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }
    
    public async ValueTask<OperationResult<bool>> Handle(AddTDetBordCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.TDetBordRepository.addT_DET_BORD_Async(request.DetBord);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}