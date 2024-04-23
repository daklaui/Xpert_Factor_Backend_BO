using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TjDocumentDetBord.Commands.DeleteTjDocumentCommand;

public class DeleteTjDocumentCommandHandler : IRequestHandler<DeleteTjDocumentCommand, OperationResult<bool>>
{ 
    private readonly IUnitOfWork _unitOfWork;

    public DeleteTjDocumentCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async ValueTask<OperationResult<bool>> Handle(DeleteTjDocumentCommand request, CancellationToken cancellationToken)
    {
        var TjDocumentToDelete = await _unitOfWork.TjDocumentDetBordRepository.GetTj_documentById(request.TjDocumentId);

        if (TjDocumentToDelete != null)
        {
            _unitOfWork.TjDocumentDetBordRepository.DeleteTj_document(TjDocumentToDelete);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
        else
        {
            return OperationResult<bool>.NotFoundResult("Bordereau not found.");
        }
    }
}