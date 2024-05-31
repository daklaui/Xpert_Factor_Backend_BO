using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Application.Features.Bordereaux.Commands.ValidateBordereauCommand;

public class ValidateBordereauCommandHandler : IRequestHandler<ValidateBordereauCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public ValidateBordereauCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async ValueTask<OperationResult<bool>> Handle(ValidateBordereauCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var pksDto = request.PksBordereauxDto;
        
            var existingBordereau = await _unitOfWork.BordereauxRepository.GetBordereauxByPK(pksDto.NUM_BORD, pksDto.REF_CTR_BORD, pksDto.ANNEE_BORD);
        
            if (existingBordereau == null)
            {
                return OperationResult<bool>.FailureResult("existingBordereau is empty" ,(false));
            }
        
            var detBordList = await _unitOfWork.TDetBordRepository.GetDetBordByPK(pksDto.NUM_BORD, pksDto.REF_CTR_BORD, pksDto.ANNEE_BORD);
        
            if (detBordList == null || !detBordList.Any())
            {
                return OperationResult<bool>.FailureResult("detbordlist is empty" ,(false));
            }
            List<T_DET_BORD> detBordListAsList = detBordList.ToList();
            await _unitOfWork.BordereauxRepository.ValidateBordereauAsync(existingBordereau, detBordListAsList);
        
            await _unitOfWork.CommitAsync();

            return OperationResult<bool>.SuccessResult(true);
        }
        catch (InvalidOperationException ex)
        {
            return OperationResult<bool>.FailureResult($"Invalid operation: {ex.Message}", false);
        }
        catch (DbUpdateException ex)
        {
            return OperationResult<bool>.FailureResult($"Database update error: {ex.Message}", false);
        }
        catch (Exception ex)
        {
            return OperationResult<bool>.FailureResult($"An unexpected error occurred: {ex.Message}", false);
        }
     
    }

}