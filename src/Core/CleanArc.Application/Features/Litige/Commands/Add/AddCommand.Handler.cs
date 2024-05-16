using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Litige.Commands.Add;

internal class AddCommand_Handler: IRequestHandler<AddCommand, OperationResult<bool>>
{
    
        private readonly IUnitOfWork _unitOfWork;

        public AddCommand_Handler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async ValueTask<OperationResult<bool>> Handle(AddCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.LitigesRepository.AddLitige(request.litige);
            await _unitOfWork.CommitAsync();

            return OperationResult<bool>.SuccessResult(true);
        }
}

