using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.AddBordereauxCommand;

public class AddBordereauxCommandHandler : IRequestHandler<AddBordereauxCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAppUserManager _userManager;

    public AddBordereauxCommandHandler(IUnitOfWork unitOfWork, IAppUserManager userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddBordereauxCommand request, CancellationToken cancellationToken)
    {
        try
        {

            T_BORDEREAU currentBord = request.Bordereau.Bordereau;
            T_BORDEREAU exsitingBord = await _unitOfWork.BordereauxRepository.GetBordereauxByPK(currentBord.NUM_BORD, currentBord.REF_CTR_BORD, currentBord.ANNEE_BORD);
            if (exsitingBord != null)
            {
                exsitingBord.REF_CTR_BORD = currentBord.REF_CTR_BORD;
                exsitingBord.REF_ADH_BORD = currentBord.REF_ADH_BORD;
                exsitingBord.NUM_BORD = currentBord.NUM_BORD;
                exsitingBord.ANNEE_BORD = currentBord.ANNEE_BORD;
                exsitingBord.NB_DOC_BORD = (short)currentBord.NB_DOC_BORD;
                exsitingBord.MONT_TOT_BORD = currentBord.MONT_TOT_BORD; //ParseDecimalOrDefault(currentBord.MONT_TOT_B);
                exsitingBord.VALIDE_BORD = false;
                exsitingBord.DAT_BORD = currentBord.DAT_BORD;
                exsitingBord.DAT_SAISIE_BORD = DateTime.Today;

            }
            else
            {
                await _unitOfWork.BordereauxRepository.addBordereauxAsync(request.Bordereau.Bordereau);
                await _unitOfWork.CommitAsync();
            }

            int maxIdDetBord = await _unitOfWork.TDetBordRepository.getMaxDocs();

            foreach (var detBord in request.Bordereau.DetBords)
            {
                var document = new T_DET_BORD()
                {
                    ID_DET_BORD = (maxIdDetBord + 1).ToString(),
                    MONT_TTC_DET_BORD = detBord.MONT_TTC_DET_BORD,
                    DAT_DET_BORD = detBord.DAT_DET_BORD,
                    MODE_REG_DET_BORD = detBord.MODE_REG_DET_BORD,
                    REF_DET_BORD = detBord.REF_DET_BORD,
                    REF_CTR_DET_BORD = currentBord.REF_CTR_BORD,
                    TYP_DET_BORD = detBord.TYP_DET_BORD,
                    NUM_BORD = currentBord.NUM_BORD,
                    ANNEE_BORD = currentBord.ANNEE_BORD,
                    MONT_OUV_DET_BORD = detBord.MONT_OUV_DET_BORD,
                    ANNUL_DET_BORD = detBord.ANNUL_DET_BORD,
                    COMM_DET_BORD = "",
                    DEVISE_DET_BORD = "TND",
                    VALIDE_DET_BORD = false
                };

                var documentRef = new TJ_DOCUMENT_DET_BORD()
                {
                    NUM_BORD = currentBord.NUM_BORD,
                    REF_CTR_DET_BORD = currentBord.REF_CTR_BORD,
                    ID_DET_BORD = document.ID_DET_BORD,
                    REF_DOCUMENT_DET_BORD = detBord.REF_DET_BORD
                };

                await _unitOfWork.TDetBordRepository.addT_DET_BORD_Async(document);
                await _unitOfWork.TjDocumentDetBordRepository.addTj_documentAsync(documentRef);
            }

            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
        catch (Exception ex)
        {
            return OperationResult<bool>.NotFoundResult("error");

        }


    }
}