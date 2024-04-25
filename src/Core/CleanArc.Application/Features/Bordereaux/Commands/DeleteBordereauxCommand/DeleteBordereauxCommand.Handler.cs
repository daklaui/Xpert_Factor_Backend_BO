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
            try
            {
                var deleteCriteria = request.BordereauToDelete;

                var bordereauToDelete = await _unitOfWork.BordereauxRepository.GetBordereauxByPK(
                    deleteCriteria.NUM_BORD,
                    deleteCriteria.REF_CTR_BORD,
                    deleteCriteria.ANNEE_BORD);

                if (bordereauToDelete == null)
                {
                    return OperationResult<bool>.NotFoundResult("Bordereau not found.");
                }

                // Delete related entries from T_DET_BORD
                var detBordsToDelete = await _unitOfWork.TDetBordRepository.GetDetBordByPK(
                    deleteCriteria.NUM_BORD,
                    deleteCriteria.REF_CTR_BORD,
                    deleteCriteria.ANNEE_BORD);

                foreach (var detBord in detBordsToDelete)
                {
                    await _unitOfWork.TDetBordRepository.DeleteT_DET_BORD(detBord);
                }

                // Delete related entries from TJ_DOCUMENT_DET_BORD
                var documentRefsToDelete = await _unitOfWork.TjDocumentDetBordRepository.GetDocumentDetBordByPK(
                    deleteCriteria.NUM_BORD,
                    deleteCriteria.REF_CTR_BORD);

                foreach (var documentRef in documentRefsToDelete)
                {
                    await _unitOfWork.TjDocumentDetBordRepository.DeleteTj_document(documentRef);
                }

                // Delete the bordereaux itself
                _unitOfWork.BordereauxRepository.DeleteBordereaux(bordereauToDelete);

                await _unitOfWork.CommitAsync();

                return OperationResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.NotFoundResult("Error deleting bordereau.");
            }
        }
    }
}