using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.AddBordereauxCommand;

public class AddBordereauxCommandHandler : IRequestHandler<AddBordereauxCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAppUserManager _userManager;
    
    public AddBordereauxCommandHandler(IUnitOfWork unitOfWork, IAppUserManager userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }
    
    public async ValueTask<OperationResult<bool>> Handle(AddBordereauxCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.BordereauxRepository.addBordereauxAsync(request.Bordereau);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}