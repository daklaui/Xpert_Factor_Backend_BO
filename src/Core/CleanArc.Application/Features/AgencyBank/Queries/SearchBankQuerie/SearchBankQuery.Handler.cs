using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Queries.RechercheBanqueQuerie;

internal class SearchBankQuery_Handler :IRequestHandler<SearchBankQuery,OperationResult<SearchBankQueryResult>>
{
    private readonly IUnitOfWork _unitOfWork;

    public SearchBankQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<SearchBankQueryResult>> Handle(SearchBankQuery request, CancellationToken cancellationToken)
    {
        var nomBanque = await _unitOfWork.AgencyBankRepository.SearchBank(request.codeBank);
        
        if (nomBanque == null)
        {
            return OperationResult<SearchBankQueryResult>.FailureResult("Bank not found");
        }

        var result = new SearchBankQueryResult
        {
            Banque = nomBanque
        };

        return OperationResult<SearchBankQueryResult>.SuccessResult(result);
    }
}