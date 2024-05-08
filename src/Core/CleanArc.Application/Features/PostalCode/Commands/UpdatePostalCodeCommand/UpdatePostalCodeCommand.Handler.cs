using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.PostalCode.Commands.UpdatePostalCodeCommand;
internal class UpdatePostalCodeCommand_Handler:IRequestHandler<UpdatePostalCodeCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdatePostalCodeCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(UpdatePostalCodeCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.PostalCodesRepository.UpdateTPostalCodesAsync(request.id,request.Cp);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}