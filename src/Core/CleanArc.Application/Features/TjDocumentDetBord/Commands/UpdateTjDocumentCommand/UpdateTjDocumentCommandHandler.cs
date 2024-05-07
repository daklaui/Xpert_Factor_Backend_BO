using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TjDocumentDetBord.Commands.UpdateTjDocumentCommand;

public class UpdateTjDocumentCommandHandler: IRequestHandler<UpdateTjDocumentCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateTjDocumentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async ValueTask<OperationResult<bool>> Handle(UpdateTjDocumentCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var updateCriteria = request.TjDetBordToUpdate;
   
            var existingDocumentDetBordList = await _unitOfWork.TjDocumentDetBordRepository.GetDocumentDetBordByPK(
                updateCriteria.NUM_BORD,
                updateCriteria.REF_CTR_DET_BORD
            );
            
            if (existingDocumentDetBordList == null || !existingDocumentDetBordList.Any())
            {
                return OperationResult<bool>.NotFoundResult("TJ_DOCUMENT_DET_BORD not found.");
            }
            var existingDocumentDetBord = existingDocumentDetBordList.First();
            
            existingDocumentDetBord.ID_DET_BORD = request.UpdateTjDocumentDetBord.ID_DET_BORD;
            existingDocumentDetBord.REF_DOCUMENT_DET_BORD = request.UpdateTjDocumentDetBord.REF_DOCUMENT_DET_BORD;
            
            await _unitOfWork.TjDocumentDetBordRepository.UpdateDocumentDetBordAsync(request.TjDetBordToUpdate, existingDocumentDetBord);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
        catch (Exception ex)
        {
            return OperationResult<bool>.FailureResult($"Error updating TJ_DOCUMENT_DET_BORD: {ex.Message}");
        }
    }
}