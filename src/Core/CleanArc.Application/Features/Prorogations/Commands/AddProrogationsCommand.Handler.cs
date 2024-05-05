using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Prorogations.Commands;

public class AddProrogationsCommandHandler:IRequestHandler<AddProrogationsCommand, OperationResult<bool>>
{
    public AddProrogationsCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    private readonly IUnitOfWork _unitOfWork;
    
    public async ValueTask<OperationResult<bool>> Handle(AddProrogationsCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.ProrogationsRepository.AddProrogationsAsync(request.prorogation);
        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}