using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Commands.AddAgencyBankCommand;

internal class AddAgencyBankCommandHandler : IRequestHandler<AddAgencyBankCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddAgencyBankCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddAgencyBankCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.AgencyBankRepository.AddTrAgencyBankAsync(request.AgBq);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}