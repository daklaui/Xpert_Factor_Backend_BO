using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Command;

public class AddInvoiceCommand_Handler: IRequestHandler<AddInvoiceCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddInvoiceCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddInvoiceCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.ContratRepository.AddInvoiceAsync(request.ListeFactureValiderk);
        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}