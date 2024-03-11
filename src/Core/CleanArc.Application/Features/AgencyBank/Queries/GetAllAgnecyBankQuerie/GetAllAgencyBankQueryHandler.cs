using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.Individu.Queries.GetAllIndividus;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Queries.GetAgnecyBankByIdQuerie;

internal class GetAllAgencyBankQueryHandler : IRequestHandler<GetAllAgencyBankQuery,OperationResult<PageInfo<GetAllAgencyBankQueryResult>>>

{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllAgencyBankQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async ValueTask<OperationResult<PageInfo<GetAllAgencyBankQueryResult>>> Handle(GetAllAgencyBankQuery request, CancellationToken cancellationToken)
    {
         var agencyBank = await _unitOfWork.AgencyBankRepository.GetAllTrAgencyBankAsync(request.paginationParams);

        var result = new PageInfo<GetAllAgencyBankQueryResult>
        {
            PageSize = agencyBank.PageSize,
            CurrentPage = agencyBank.CurrentPage,
            TotalPages = agencyBank.TotalPages,
            TotalCount = agencyBank.TotalCount,
            Result = agencyBank.Select(_mapper.Map<TR_Ag_Bq, GetAllAgencyBankQueryResult>).ToList()

        };
        return OperationResult<PageInfo<GetAllAgencyBankQueryResult>>.SuccessResult(result);
    }
    
}