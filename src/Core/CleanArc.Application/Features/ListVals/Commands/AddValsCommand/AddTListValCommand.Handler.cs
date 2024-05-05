using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.TListVal.Commands;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVals.Commands.AddValsCommand;

internal class AddTListValCommandHandler : IRequestHandler<AddTListValCommand, OperationResult<bool>>
{
    private readonly ITListValRepository _tListValRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddTListValCommandHandler(ITListValRepository tListValRepository, IUnitOfWork unitOfWork)
    {
        _tListValRepository = tListValRepository;
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddTListValCommand request, CancellationToken cancellationToken)
    {
        await _tListValRepository.AddTListValAsync(request.listVal);
        await _unitOfWork.CommitAsync();
        return OperationResult<bool>.SuccessResult(true);
    }
}
