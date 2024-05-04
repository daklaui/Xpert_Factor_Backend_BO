using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Financement.Commands.UpdateFinancementCommand;

public class ValidateFinanceCommandHandler : IRequestHandler<ValidateFinanceCommand,OperationResult<Unit>>
{
    private readonly IFinancementRepository _financementRepository;
    private readonly IMapper _mapper;

    public ValidateFinanceCommandHandler(IFinancementRepository financementRepository, IMapper mapper)
    {
        _financementRepository = financementRepository ?? throw new ArgumentNullException(nameof( financementRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }


    public async ValueTask<OperationResult<Unit>> Handle(ValidateFinanceCommand request, CancellationToken cancellationToken)
    {
        var finance = await _financementRepository.GetFinanceById(request.ID_FIN);

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
                await _financementRepository.ValidateFinanceAsync(finance.ID_FIN, finance);
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
