using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Credit.Commands;

internal class AddCreditCommand_Handler :IRequestHandler<AddCreditCommand,OperationResult<bool>>
{
    
    private readonly IUnitOfWork _unitOfWork;

    public AddCreditCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddCreditCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.CreditRepository.AddCreditAsync(request.MvtCredit);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);    }
}