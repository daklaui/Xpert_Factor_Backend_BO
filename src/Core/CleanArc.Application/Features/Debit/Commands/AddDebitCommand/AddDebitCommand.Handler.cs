using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Debit.Commands.AddDebitCommand;

internal class AddDebitCommand_Handler :IRequestHandler<AddDebitCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddDebitCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddDebitCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.DebitRepository.AddDebitAsync(request.mvtDebit);
        await _unitOfWork.CommitAsync();
        return OperationResult<bool>.SuccessResult(true);  
    }
}