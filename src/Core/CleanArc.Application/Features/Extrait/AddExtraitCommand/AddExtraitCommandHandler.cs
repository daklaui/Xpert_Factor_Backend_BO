using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Extrait.AddExtraitCommand;

public class AddExtraitCommandHandler: IRequestHandler<AddExtraitCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAppUserManager _userManager;
    
    public AddExtraitCommandHandler(IUnitOfWork unitOfWork, IAppUserManager userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }
    public async ValueTask<OperationResult<bool>> Handle(AddExtraitCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.ExtraitRepository.addExtraitAsync(request.Extrait);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}



