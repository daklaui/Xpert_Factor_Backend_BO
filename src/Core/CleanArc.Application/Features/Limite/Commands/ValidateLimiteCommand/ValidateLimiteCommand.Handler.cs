using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Limite.Commands.ValidateLimiteCommand;

internal class ValidateLimite_Handler : IRequestHandler<ValidateLimiteCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public ValidateLimite_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(ValidateLimiteCommand request,
        CancellationToken cancellationToken)
    {
        var limite = await _unitOfWork.LimiteRepository.GetDemLimiteById(request.REF_DEM_LIM);
        if (limite == null)
        {
            throw new KeyNotFoundException($"limite with ID {request.REF_DEM_LIM} not found");
        }    
        limite.ACTIF_DEM_LIMI = true;
            limite.DECISION_LIM = "V";

            await _unitOfWork.LimiteRepository.validateLimite(limite.REF_DEM_LIM);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
            


        
    }
}