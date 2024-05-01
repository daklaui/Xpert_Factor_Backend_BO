using CleanArc.Application.Contracts.Persistence;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.ValidateBordereauCommand;

public class ValidateBordereauCommandHandler : IRequestHandler<ValidateBordereauCommand, bool>
{
    private readonly IUnitOfWork _unitOfWork;

    public ValidateBordereauCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async ValueTask<bool> Handle(ValidateBordereauCommand request, CancellationToken cancellationToken)
    {
        var pksDto = request.PksBordereauxDto;
        
        var existingBordereau = await _unitOfWork.BordereauxRepository.GetBordereauxByPK(pksDto.NUM_BORD, pksDto.REF_CTR_BORD, pksDto.ANNEE_BORD);
        
        if (existingBordereau == null)
        {
            return false;
        }
        
        var detBordList = await _unitOfWork.TDetBordRepository.GetDetBordByPK(pksDto.NUM_BORD, pksDto.REF_CTR_BORD, pksDto.ANNEE_BORD);
        
        if (detBordList == null || !detBordList.Any())
        {
            return false;
        }
        List<T_DET_BORD> detBordListAsList = detBordList.ToList();
        await _unitOfWork.BordereauxRepository.ValidateBordereauAsync(existingBordereau, detBordListAsList);
        
        await _unitOfWork.CommitAsync();

        return true;
    }

}