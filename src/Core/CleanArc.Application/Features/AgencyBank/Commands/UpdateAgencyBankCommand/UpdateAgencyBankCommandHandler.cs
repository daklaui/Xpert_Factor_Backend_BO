using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Commands.UpdateAgencyBankCommand;

internal class UpdateAgencyBankCommandHandler : IRequestHandler<UpdateAgencyBankCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateAgencyBankCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(UpdateAgencyBankCommand request, CancellationToken cancellationToken)
    {
        var bankAgency = await _unitOfWork.AgencyBankRepository.GetTrAgencyBankById(request.Code_Bq_Ag);

        if (bankAgency == null)
        {
            return OperationResult<bool>.FailureResult("Bank agency not found");
        }

        bankAgency.Code_Ag = request.Code_Ag;
        bankAgency.Agence = request.Agence;
        bankAgency.Code_Bq = request.Code_Bq;
        bankAgency.Banque = request.Banque;

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}
