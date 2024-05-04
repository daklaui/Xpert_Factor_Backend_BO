using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;


namespace CleanArc.Application.Features.Debit.Commands.AddDebitCommand;

public class AddDebitCommandHandler: IRequestHandler<AddDebitCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAppUserManager _userManager;
    
    public AddDebitCommandHandler(IUnitOfWork unitOfWork, IAppUserManager userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }
    
    public async ValueTask<OperationResult<bool>> Handle(AddDebitCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.DebitRepository.addDebitAsync(request.Debit);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}