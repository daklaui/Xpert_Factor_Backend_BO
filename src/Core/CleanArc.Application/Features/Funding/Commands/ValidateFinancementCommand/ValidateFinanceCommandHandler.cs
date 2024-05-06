using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Financement.Commands.UpdateFinancementCommand;

public class ValidateFinanceCommandHandler : IRequestHandler<ValidateFinanceCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;


   
    public ValidateFinanceCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
 
    }

    public async ValueTask<OperationResult<bool>> Handle(ValidateFinanceCommand request,
        CancellationToken cancellationToken)
    {
        var finance = await _unitOfWork.FundingRepository.GetFinanceById(request.ID_FIN);

        if (finance == null)
        {
            throw new KeyNotFoundException($"Finance with ID {request.ID_FIN} not found");
        }
        
        finance.ETAT_FIN = "valider";

        await _unitOfWork.FundingRepository.ValidateFinanceAsync(finance.ID_FIN);
        await _unitOfWork.CommitAsync();
        return OperationResult<bool>.SuccessResult(true);

    }

}
