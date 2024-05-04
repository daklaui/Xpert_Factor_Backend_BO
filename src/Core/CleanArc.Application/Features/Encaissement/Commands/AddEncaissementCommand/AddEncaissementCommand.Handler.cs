using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Encaissement.Commands.AddEncaissementCommand;

public class AddEncaissementCommand_Handler: IRequestHandler<AddEncaissementCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddEncaissementCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddEncaissementCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.EncaissementRepository.AddEncaissementAsync(request.Encaissement);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}