using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.buyer.Commands.AddBuyerLimit;

internal class AddBuyerLimitCommmandHandler  : IRequestHandler<AddBuyerLimitCommmand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    
    public async ValueTask<OperationResult<bool>> Handle(AddBuyerLimitCommmand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.tjcirRepository.AddBuyer(request.Buyer);
        await _unitOfWork.LimiteRepository.AddBuyerLimit(request.Buyer);
        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}