using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Encaissement.Queries.ListeRecherchEncCtr;

internal class RecherchEncCtrQuery_Handler : IRequestHandler<RecherchEncCtrQuery, OperationResult<List<RecherchEncCtrQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RecherchEncCtrQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

  
 
     
        public async ValueTask<OperationResult<List<RecherchEncCtrQuery_Response>>> Handle(RecherchEncCtrQuery request, CancellationToken cancellationToken)
        {
            var listEncCtr = await _unitOfWork.EncaissementRepository.RecherchEncCtr(request.refCtr);

       
            var mappedResults = listEncCtr.Select(enc => _mapper.Map<RecherchEncCtrQuery_Response>(enc)).ToList();

            return OperationResult<List<RecherchEncCtrQuery_Response>>.SuccessResult(mappedResults);

        }
}