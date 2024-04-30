using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.RIB.Commands.AddRibCommand;

internal class AddRibCommand_Handler: IRequestHandler<AddRibCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddRibCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddRibCommand request, CancellationToken cancellationToken)
    {
        {
            await _unitOfWork.ribRepository.AddRibAsync(request.rib);

            await _unitOfWork.CommitAsync();

            return OperationResult<bool>.SuccessResult(true);
        }

      
    }
}