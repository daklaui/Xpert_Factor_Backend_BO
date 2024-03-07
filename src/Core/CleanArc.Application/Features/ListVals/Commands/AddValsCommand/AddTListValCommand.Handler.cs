using Mediator;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;

namespace CleanArc.Application.Features.ListVals.Commands
{
    internal class AddTListValCommandHandler : IRequestHandler<AddTListValCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddTListValCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddTListValCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.TListValRepository.AddTListValAsync(request.TRListVals);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
    }

}

