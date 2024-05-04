using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Limite.Commands.ValidateLimiteCommand;

public class ValidateLimite_Handler : IRequestHandler<ValidateLimiteCommand, OperationResult<Unit>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ValidateLimite_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async ValueTask<OperationResult<Unit>> Handle(ValidateLimiteCommand request,
        CancellationToken cancellationToken)
    {
        var limite = await _unitOfWork.LimiteRepository.GetDemLimiteById(request.REF_DEM_LIM);
        if (limite == null)
        {
            throw new KeyNotFoundException($"limite with ID {request.REF_DEM_LIM} not found");
        }

        if (limite.ACTIF_DEM_LIMI == false)
        {
            limite.ACTIF_DEM_LIMI = true;
            limite.DECISION_LIM = "V";
            _mapper.Map(request, limite);
            try
            {
                await _unitOfWork.LimiteRepository.validateLimite(limite.REF_DEM_LIM, limite);
                return OperationResult<Unit>.SuccessResult(Unit.Value);

            }catch (Exception ex)
            {
                return OperationResult<Unit>.FailureResult($"Error updating limite: {ex.Message}");
            }
        }
        return OperationResult<Unit>.SuccessResult(Unit.Value);


    }
}