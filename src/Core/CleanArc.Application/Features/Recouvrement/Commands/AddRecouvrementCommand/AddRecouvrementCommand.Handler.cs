using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Recouvrement.Commands;

internal class AddRecouvrementCommandHandler: IRequestHandler<AddRecouvrementCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAppUserManager _userManager;

    public AddRecouvrementCommandHandler(IUnitOfWork unitOfWork, IAppUserManager userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }
    public async ValueTask<OperationResult<bool>> Handle(AddRecouvrementCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.RecouvrementRepository.AddRecouvrementAsync(request.Recouvrement);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}