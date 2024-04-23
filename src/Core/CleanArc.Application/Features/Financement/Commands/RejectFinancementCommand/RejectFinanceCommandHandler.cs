using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Financement.Commands.RejectFinancementCommand;

public class RejectFinanceCommandHandler :IRequestHandler<RejectFinanceCommand,OperationResult<Unit>>
{
    private readonly IFinancementRepository _financementRepository;
    private readonly IMapper _mapper;

    public RejectFinanceCommandHandler(IFinancementRepository financementRepository, IMapper mapper)
    {
        _financementRepository = financementRepository;
        _mapper = mapper;
    }


    public async ValueTask<OperationResult<Unit>> Handle(RejectFinanceCommand request, CancellationToken cancellationToken)
    {
        var finance = await _financementRepository.GetFinanceById(request.ID_FIN);

        if (finance == null)
        {
            throw new KeyNotFoundException($"Finance with ID {request.ID_FIN} not found");
        }

        if (finance.ETAT_FIN != "rejeter")
        {
            finance.ETAT_FIN = "rejeter";
            _mapper.Map(request, finance);
            try
            {
                await _financementRepository.RejectFinanceAsync(finance.ID_FIN, finance);
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