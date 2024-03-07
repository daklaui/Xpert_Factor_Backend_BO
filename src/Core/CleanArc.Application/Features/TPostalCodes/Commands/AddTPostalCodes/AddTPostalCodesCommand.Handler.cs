using Mediator;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.TPostalCodes.Commands;
using CleanArc.Application.Models.Common;

namespace CleanArc.Application.Features.TPostalCodes.Commands
{
    public class AddTPostalCodesCommandHandler : IRequestHandler<AddTPostalCodesCommand, OperationResult<bool>>
    {
        
        private readonly IUnitOfWork _unitOfWork;

        public AddTPostalCodesCommandHandler(ITPostalCodesRepository tPostalCodesRepository, IUnitOfWork unitOfWork)
        {
            
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddTPostalCodesCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.TPostalCodesRepository.AddTPostalCodesAsync(request.TPostalCodes);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
    }
}