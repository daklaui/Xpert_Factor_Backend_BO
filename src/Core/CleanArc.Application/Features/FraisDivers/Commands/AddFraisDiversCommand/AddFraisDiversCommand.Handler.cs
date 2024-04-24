using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.FraisDivers.Commands.AddFraisDiversCommand
{
    internal class AddFraisDiversCommandHandler : IRequestHandler<AddFraisDiversCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddFraisDiversCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async ValueTask<OperationResult<bool>> Handle(AddFraisDiversCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.FraisDiversRepository.AddFraisDiversAsync(request.FraisDivers);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
    }
}
