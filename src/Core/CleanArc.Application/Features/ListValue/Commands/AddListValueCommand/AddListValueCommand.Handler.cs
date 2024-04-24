using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListValue.Commands.AddListValueCommand
{
    internal class AddListValueCommandHandler : IRequestHandler<AddListValueCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddListValueCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddListValueCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.ListValueRepository.AddListValueAsync(request.ListValue);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
    }
}
