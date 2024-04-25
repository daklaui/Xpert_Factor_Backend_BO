using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;


namespace CleanArc.Application.Features.Credit.Commands.AddCreditCommand;
public class AddCreditCommandHandler: IRequestHandler<AddCreditCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAppUserManager _userManager;
    
    public AddCreditCommandHandler(IUnitOfWork unitOfWork, IAppUserManager userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }
    
    public async ValueTask<OperationResult<bool>> Handle(AddCreditCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.CreditRepository.AddCreditAsync(request.Credit);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}