using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TMM.Commands.AddTmmCommand;

internal class AddTmmCommandHandler : IRequestHandler<AddTmmCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddTmmCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddTmmCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.TmmRepository.AddTrTmmAsync(request.trTmm);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}