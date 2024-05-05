using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Commands.AddListVal;

internal class AddListValCommandHandler : IRequestHandler<AddListValCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddListValCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddListValCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.ValuesListRepository.AddListValAsync(request.ListVal);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}