using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Commands.UpdateTDetBordCommand;

public class UpdateTDetBordCommandHandler: IRequestHandler<UpdateTDetBordCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateTDetBordCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async ValueTask<OperationResult<bool>> Handle(UpdateTDetBordCommand request, CancellationToken cancellationToken)
{
    try
    {
        var updateCriteria = request.TdetBordToUpdate;

       
        var existingDetBordList = await _unitOfWork.TDetBordRepository.GetDetBordByPK(
            updateCriteria.NUM_BORD,
            updateCriteria.REF_CTR_DET_BORD,
            updateCriteria.ANNEE_BORD
        );

        if (existingDetBordList == null || !existingDetBordList.Any())
        {
            return OperationResult<bool>.NotFoundResult("T_DET_BORD not found.");
        }

        
        var existingDetBord = existingDetBordList.First();
        
        existingDetBord.TYP_DET_BORD = request.updatedDetBord.TYP_DET_BORD;
        existingDetBord.NUM_CREANCE_ASS_BORD = request.updatedDetBord.NUM_CREANCE_ASS_BORD;
        existingDetBord.TYP_ASS_DET_BORD = request.updatedDetBord.TYP_ASS_DET_BORD;
        existingDetBord.DAT_DET_BORD = request.updatedDetBord.DAT_DET_BORD;
        existingDetBord.MONT_TTC_DET_BORD = request.updatedDetBord.MONT_TTC_DET_BORD;
        existingDetBord.DEVISE_DET_BORD = request.updatedDetBord.DEVISE_DET_BORD;
        existingDetBord.ECH_DET_BORD = request.updatedDetBord.ECH_DET_BORD;
        existingDetBord.ECH_APR_PROROG_DET_BORD = request.updatedDetBord.ECH_APR_PROROG_DET_BORD;
        existingDetBord.MONT_OUV_DET_BORD = request.updatedDetBord.MONT_OUV_DET_BORD;
        existingDetBord.DELAI_PAIE_DET_BORD = request.updatedDetBord.DELAI_PAIE_DET_BORD;
        existingDetBord.MODE_REG_DET_BORD = request.updatedDetBord.MODE_REG_DET_BORD;
        existingDetBord.TYP_REG_DET_BORD = request.updatedDetBord.TYP_REG_DET_BORD;
        existingDetBord.TX_FDG_DET_BORD = request.updatedDetBord.TX_FDG_DET_BORD;
        existingDetBord.TX_COMM_FACT_DET_BORD = request.updatedDetBord.TX_COMM_FACT_DET_BORD;
        existingDetBord.ANNUL_DET_BORD = request.updatedDetBord.ANNUL_DET_BORD;
        existingDetBord.VALIDE_DET_BORD = request.updatedDetBord.VALIDE_DET_BORD;
        existingDetBord.REF_IND_DET_BORD = request.updatedDetBord.REF_IND_DET_BORD;
        existingDetBord.MONT_FDG_DET_BORD = request.updatedDetBord.MONT_FDG_DET_BORD;
        existingDetBord.MONT_FDG_LIBERE_DET_BORD = request.updatedDetBord.MONT_FDG_LIBERE_DET_BORD;
        existingDetBord.MONT_COMM_FACT_DET_BORD = request.updatedDetBord.MONT_COMM_FACT_DET_BORD;
        existingDetBord.TX_TVA_COMM_FACT_DET_BORD = request.updatedDetBord.TX_TVA_COMM_FACT_DET_BORD;
        existingDetBord.MONT_TVA_COMM_FACT_DET_BORD = request.updatedDetBord.MONT_TVA_COMM_FACT_DET_BORD;
        existingDetBord.MONT_TTC_COMM_FACT_DET_BORD = request.updatedDetBord.MONT_TTC_COMM_FACT_DET_BORD;
        existingDetBord.ID_CALC_DISPO_DET_BORD = request.updatedDetBord.ID_CALC_DISPO_DET_BORD;
        existingDetBord.REF_DET_BORD = request.updatedDetBord.REF_DET_BORD;
        existingDetBord.COMM_DET_BORD = request.updatedDetBord.COMM_DET_BORD;
        existingDetBord.RETENU_DET_BORD = request.updatedDetBord.RETENU_DET_BORD;

       
        await _unitOfWork.TDetBordRepository.UpdateDetBordAsync(request.TdetBordToUpdate, existingDetBord);
        
        
        await _unitOfWork.CommitAsync();

        
        return OperationResult<bool>.SuccessResult(true);
    }
    catch (Exception ex)
    {
        return OperationResult<bool>.FailureResult($"Error updating T_DET_BORD: {ex.Message}");
    }
}

}