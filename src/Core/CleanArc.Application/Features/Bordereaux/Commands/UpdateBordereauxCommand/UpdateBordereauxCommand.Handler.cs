using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;


namespace CleanArc.Application.Features.Bordereaux.Commands.UpdateBordereauxCommand;

public class UpdateBordereauxCommandHandler: IRequestHandler<UpdateBordereauxCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateBordereauxCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async ValueTask<OperationResult<bool>> Handle(UpdateBordereauxCommand request, CancellationToken cancellationToken)
    {
        try
        {
           
            var existingBordereau = await _unitOfWork.BordereauxRepository.GetBordereauxByPK(
                request.BordereauToUpdate.Bordereau.NUM_BORD,
                request.BordereauToUpdate.Bordereau.REF_CTR_BORD,
                request.BordereauToUpdate.Bordereau.ANNEE_BORD
            );

            if (existingBordereau == null)
            {
                return OperationResult<bool>.NotFoundResult("Bordereau not found.");
            }

           
            _mapper.Map(request.BordereauToUpdate.Bordereau, existingBordereau);

            PksBordereauxDto pksBordereauxDto = new PksBordereauxDto
            {
                NUM_BORD = request.BordereauToUpdate.Bordereau.NUM_BORD,
                REF_CTR_BORD = request.BordereauToUpdate.Bordereau.REF_CTR_BORD,
                ANNEE_BORD = request.BordereauToUpdate.Bordereau.ANNEE_BORD
            };

            await _unitOfWork.BordereauxRepository.UpdateBordereauxAsync(pksBordereauxDto, existingBordereau);

            
            foreach (var updatedDetBordDto in request.BordereauToUpdate.DetBords)
            {
               
                var existingDetBordList = await _unitOfWork.TDetBordRepository.GetDetBordByPK(
                    updatedDetBordDto.NUM_BORD,
                    updatedDetBordDto.REF_CTR_DET_BORD,
                    updatedDetBordDto.ANNEE_BORD
                );

                if (existingDetBordList == null || !existingDetBordList.Any())
                {
                    return OperationResult<bool>.NotFoundResult($"T_DET_BORD not found for {updatedDetBordDto.NUM_BORD}, {updatedDetBordDto.REF_CTR_DET_BORD}, {updatedDetBordDto.ANNEE_BORD}.");
                }
                
               
                foreach (var existingDetBord in existingDetBordList)
                {
                    _mapper.Map(updatedDetBordDto, existingDetBord);
                    
                  
                    PksDetBordDto pksDetBordDto = new PksDetBordDto
                    {
                        NUM_BORD = updatedDetBordDto.NUM_BORD,
                        REF_CTR_DET_BORD = updatedDetBordDto.REF_CTR_DET_BORD,
                        ANNEE_BORD = updatedDetBordDto.ANNEE_BORD
                    };

                    await _unitOfWork.TDetBordRepository.UpdateDetBordAsync(pksDetBordDto, existingDetBord);
                }
            }

          
            foreach (var updatedDocument in request.UpdatedDocuments)
            {
              
                var existingDocumentDetBordList = await _unitOfWork.TjDocumentDetBordRepository.GetDocumentDetBordByPK(
                    updatedDocument.NUM_BORD,
                    updatedDocument.REF_CTR_DET_BORD
                );

                if (existingDocumentDetBordList == null || !existingDocumentDetBordList.Any())
                {
                    return OperationResult<bool>.NotFoundResult($"TJ_DOCUMENT_DET_BORD not found for {updatedDocument.NUM_BORD}, {updatedDocument.REF_CTR_DET_BORD}.");
                }

                foreach (var existingDocumentDetBord in existingDocumentDetBordList)
                {
                  
                    _mapper.Map(updatedDocument, existingDocumentDetBord);

                  
                    PksTjDetBord pksTjDetBord = new PksTjDetBord
                    {
                        NUM_BORD = updatedDocument.NUM_BORD,
                        REF_CTR_DET_BORD = updatedDocument.REF_CTR_DET_BORD
                    };

                   
                    await _unitOfWork.TjDocumentDetBordRepository.UpdateDocumentDetBordAsync(pksTjDetBord, existingDocumentDetBord);
                }
            }

          
            await _unitOfWork.CommitAsync();

       
            return OperationResult<bool>.SuccessResult(true);
        }
        catch (Exception ex)
        {
          
            return OperationResult<bool>.FailureResult($"Error updating bordereaux: {ex.Message}");
        }
    }
}