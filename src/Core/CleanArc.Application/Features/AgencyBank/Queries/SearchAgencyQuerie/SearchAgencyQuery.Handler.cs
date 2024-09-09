using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.AgencyBank.Queries.RechercheBanqueQuerie;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Queries.SearchAgencyQuerie;

internal class SearchAgencyQuery_Handler:IRequestHandler<SearchAgencyQuery,OperationResult<SearchAgencyQueryResult>>
{
    private readonly IUnitOfWork _unitOfWork;

    public SearchAgencyQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
    }

    public async  ValueTask<OperationResult<SearchAgencyQueryResult>> Handle(SearchAgencyQuery request, CancellationToken cancellationToken)
    {
        var nomAgency = await _unitOfWork.AgencyBankRepository.ResearchAgency(request.codeAgency);
        if (nomAgency == null)
        {
         return OperationResult<SearchAgencyQueryResult>.FailureResult("Bank not found");
        }

        var result = new SearchAgencyQueryResult
        {
            Banque = nomAgency
        };

        return OperationResult<SearchAgencyQueryResult>.SuccessResult(result);
    }
}