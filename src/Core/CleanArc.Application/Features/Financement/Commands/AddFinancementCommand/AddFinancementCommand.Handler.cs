using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;
using NuGet.Protocol.Plugins;

namespace CleanArc.Application.Features.Financement.Commands.AddFinancementCommand;

public class AddFinancementCommand_Handler:IRequestHandler<AddFinancementCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddFinancementCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddFinancementCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.FinancementRepository.AddFinanceAsync(request.Financement);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}