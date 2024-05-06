using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Financement.Commands.RejectFinancementCommand;

public class RejectFinanceCommandHandler :IRequestHandler<RejectFinanceCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
   

    public RejectFinanceCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    
    }


    public async ValueTask<OperationResult<bool>> Handle(RejectFinanceCommand request, CancellationToken cancellationToken)
    {
        var finance = await _unitOfWork.FundingRepository.GetFinanceById(request.ID_FIN);

        if (finance == null)
        {
            throw new KeyNotFoundException($"Finance with ID {request.ID_FIN} not found");
        } 
        finance.ETAT_FIN = "0";
        
                await _unitOfWork.FundingRepository.RejectFinanceAsync(finance.ID_FIN);
                await _unitOfWork.CommitAsync();
                return OperationResult<bool>.SuccessResult(true);    }
}