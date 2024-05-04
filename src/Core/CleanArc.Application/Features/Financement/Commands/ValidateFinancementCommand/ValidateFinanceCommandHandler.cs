using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Financement.Commands.UpdateFinancementCommand;

public class ValidateFinanceCommandHandler : IRequestHandler<ValidateFinanceCommand,OperationResult<Unit>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

   
    public ValidateFinanceCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async ValueTask<OperationResult<Unit>> Handle(ValidateFinanceCommand request, CancellationToken cancellationToken)
    {
        var finance = await _unitOfWork.FundingRepository.GetFinanceById(request.ID_FIN);

        if (finance == null)
        {
            throw new KeyNotFoundException($"Finance with ID {request.ID_FIN} not found");
        }

        if (finance.ETAT_FIN != "valider")
        {
            finance.ETAT_FIN = "valider";
            _mapper.Map(request, finance);
            try
            {
                await  _unitOfWork.FundingRepository.ValidateFinanceAsync(finance.ID_FIN, finance);
                return OperationResult<Unit>.SuccessResult(Unit.Value);
            }
            catch (Exception ex)
            {
                return OperationResult<Unit>.FailureResult($"Error updating TPostalCodes: {ex.Message}");
            }
        }
    
        return OperationResult<Unit>.SuccessResult(Unit.Value);
        
    }
}
