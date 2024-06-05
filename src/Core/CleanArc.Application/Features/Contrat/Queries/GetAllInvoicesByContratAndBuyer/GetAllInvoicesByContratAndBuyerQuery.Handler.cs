using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.StoredProcuderModel;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Queries.GetAllInvoicesByContratAndBuyer;

internal class GetAllInvoicesByContratAndBuyerQueryHandler:IRequestHandler<GetAllInvoicesByContratAndBuyerQuery,OperationResult<List<ListeFactureValiderk>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllInvoicesByContratAndBuyerQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    } 

    public async ValueTask<OperationResult<List<ListeFactureValiderk>>> Handle(GetAllInvoicesByContratAndBuyerQuery request, CancellationToken cancellationToken)
    {
        var listeFactures = await _unitOfWork.ContratRepository.GetAllInvoicesByContratAndBuyer(request.id1,request.id2);
        return OperationResult<List<ListeFactureValiderk>>.SuccessResult(listeFactures);
    }
}