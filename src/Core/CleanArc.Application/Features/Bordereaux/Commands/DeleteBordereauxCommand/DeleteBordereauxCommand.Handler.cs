using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.DeleteBordereauxCommand
{
    public class DeleteBordereauxCommandHandler : IRequestHandler<DeleteBordereauxCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBordereauxCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(DeleteBordereauxCommand request, CancellationToken cancellationToken)
        {
            var bordereauToDelete = await _unitOfWork.BordereauxRepository.GetBordereauxById(request.BordereauId);

            if (bordereauToDelete != null)
            {
                _unitOfWork.BordereauxRepository.DeleteBordereaux(bordereauToDelete);
                await _unitOfWork.CommitAsync();
                return OperationResult<bool>.SuccessResult(true);
            }
            else
            {
                return OperationResult<bool>.NotFoundResult("Bordereau not found.");
            }
        }
    }
}