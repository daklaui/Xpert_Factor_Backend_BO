using Mediator;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;

namespace CleanArc.Application.Features.TListVal.Commands;

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
        await _tListValRepository.AddTListValAsync(request.ListVals);
        await _unitOfWork.CommitAsync();
        return OperationResult<bool>.SuccessResult(true);
    }
}
