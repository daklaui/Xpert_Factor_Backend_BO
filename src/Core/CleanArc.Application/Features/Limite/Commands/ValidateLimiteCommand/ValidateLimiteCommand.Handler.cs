using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;
using Microsoft.Extensions.Logging;

namespace CleanArc.Application.Features.Limite.Commands.ValidateLimiteCommand;

internal class ValidateLimite_Handler : IRequestHandler<ValidateLimiteCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<ValidateLimite_Handler> _logger;

    public ValidateLimite_Handler(IUnitOfWork unitOfWork, ILogger<ValidateLimite_Handler> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async ValueTask<OperationResult<bool>> Handle(ValidateLimiteCommand request,
        CancellationToken cancellationToken)
    {
        _logger.LogInformation("Handling ValidateLimiteCommand for REF_DEM_LIM: {REF_DEM_LIM}", request.REF_DEM_LIM);

        var limite = await _unitOfWork.LimiteRepository.GetDemLimiteById(request.REF_DEM_LIM);
        if (limite == null)
        {
            _logger.LogError("Limite with ID {REF_DEM_LIM} not found", request.REF_DEM_LIM);
            throw new KeyNotFoundException($"limite with ID {request.REF_DEM_LIM} not found");
        }

        _logger.LogInformation("Found Limite with ID {REF_DEM_LIM}, validating...", request.REF_DEM_LIM);

        await _unitOfWork.LimiteRepository.validateLimite(limite.REF_DEM_LIM);
        await _unitOfWork.CommitAsync();
        
        _logger.LogInformation("Limite with ID {REF_DEM_LIM} validated successfully", request.REF_DEM_LIM);
        return OperationResult<bool>.SuccessResult(true);
    }
}
