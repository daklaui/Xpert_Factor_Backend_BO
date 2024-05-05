using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Litiges.Commands;

public class AddLitigesCommandHandler:IRequestHandler<AddLitigesCommand, OperationResult<bool>>
{
    public AddLitigesCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    private readonly IUnitOfWork _unitOfWork;
    
    public async ValueTask<OperationResult<bool>> Handle(AddLitigesCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.LitigesRepository.AddLitigesAsync(request.litige,request.MONT_LT);
        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}