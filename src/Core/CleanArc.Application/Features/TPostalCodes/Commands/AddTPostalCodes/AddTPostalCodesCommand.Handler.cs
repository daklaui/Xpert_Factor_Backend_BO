using Mediator;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.TPostalCodes.Commands;
using CleanArc.Application.Models.Common;

namespace CleanArc.Application.Features.TPostalCodes.Commands
{
    public class AddTPostalCodesCommandHandler : IRequestHandler<AddTPostalCodesCommand, OperationResult<bool>>
    {
        private readonly ITPostalCodesRepository _tPostalCodesRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AddTPostalCodesCommandHandler(ITPostalCodesRepository tPostalCodesRepository, IUnitOfWork unitOfWork)
        {
            _tPostalCodesRepository = tPostalCodesRepository;
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddTPostalCodesCommand request, CancellationToken cancellationToken)
        {
            await _tPostalCodesRepository.AddTPostalCodesAsync(request.trCp);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
    }
}