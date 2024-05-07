using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Commands.AddValsCommand;

internal class AddTListValCommandHandler : IRequestHandler<AddTListValCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddTListValCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddTListValCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.ListValRepository.AddTListValAsync(request.listVal);
        await _unitOfWork.CommitAsync();
        return OperationResult<bool>.SuccessResult(true);
    }
}
