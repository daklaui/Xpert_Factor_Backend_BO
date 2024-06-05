using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.StoredProcuderModel;
using Mediator;

namespace CleanArc.Application.Features.Encaissement.Queries.ListeEncAchRefCtr;

internal class ListeEncAchRefCtrQuery_Handler : IRequestHandler<ListeEncAchRefCtrQuery, OperationResult<List<ListeEncAchRefCtrQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ListeEncAchRefCtrQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<List<ListeEncAchRefCtrQuery_Response>>> Handle(ListeEncAchRefCtrQuery request, CancellationToken cancellationToken)
    {
 
        var listEncAchRefCtr = await _unitOfWork.EncaissementRepository.RecherchEncAchRefCtr(request.refCtr, request.refAch);

       
        var mappedResults = listEncAchRefCtr.Select(enc => _mapper.Map<ListeEncAchRefCtrQuery_Response>(enc)).ToList();

        return OperationResult<List<ListeEncAchRefCtrQuery_Response>>.SuccessResult(mappedResults);
    }
}