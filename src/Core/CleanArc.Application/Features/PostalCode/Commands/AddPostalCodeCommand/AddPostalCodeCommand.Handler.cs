using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.PostalCode.Commands.AddPostalCodeCommand;

internal class AddPostalCodeCommand_Handler:IRequestHandler<AddPostalCodeCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddPostalCodeCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddPostalCodeCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.PostalCodesRepository.AddTPostalCodesAsync(request.TrCp);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}