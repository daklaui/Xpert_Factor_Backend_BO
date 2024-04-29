
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.buyer.Commands.AddBuyer;
using CleanArc.Application.Models.Common;
using Mediator;


namespace CleanArc.Application.Features.Buyer.Commands.AddBuyer
{
    public class AddBuyerCommandHandler : IRequestHandler<AddBuyerCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddBuyerCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddBuyerCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.TJcirRepository.AddTJCIRsync(request.Buyer);
            await _unitOfWork.CommitAsync();

            return OperationResult<bool>.SuccessResult(true);
        }
    }
}