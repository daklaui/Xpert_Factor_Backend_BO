using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;
namespace CleanArc.Application.Features.FactoringCommission.Commands.AddFactoringCommissionCommand
{
    internal class AddFactoringCommissionCommandHandler : IRequestHandler<AddFactoringCommissionCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddFactoringCommissionCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddFactoringCommissionCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.FactoringCommissionRepository.AddFactoringCommissionAsync(request.FactoringCommission);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
    }
}
