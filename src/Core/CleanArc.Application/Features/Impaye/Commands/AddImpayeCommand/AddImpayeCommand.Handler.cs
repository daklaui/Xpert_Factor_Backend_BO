using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Impaye.Commands.AddImpayeCommand;

internal class AddImpayeCommand_Handler :IRequestHandler<AddImpayeCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddImpayeCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddImpayeCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.ImpayeRepository.AddImpayeAsync(request.Impaye);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}