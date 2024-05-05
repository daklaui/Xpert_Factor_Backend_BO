using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Prorogation.Commands.AddProrogation;

public class AddProrogationCommand_Handler:IRequestHandler<AddProrogationCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddProrogationCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public  async ValueTask<OperationResult<bool>> Handle(AddProrogationCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.ProrogationsRepository.AddProrogation(request.Prorogation, request.EcheanceFacturePro);
        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}