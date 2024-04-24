using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TR_CP.Commands.AddTR_CPCommand
{
    internal class AddTR_CPCommandHandler : IRequestHandler<AddTR_CPCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddTR_CPCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddTR_CPCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.TR_CPRepository.AddTR_CPAsync(request.TR_CP);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
    }
}
