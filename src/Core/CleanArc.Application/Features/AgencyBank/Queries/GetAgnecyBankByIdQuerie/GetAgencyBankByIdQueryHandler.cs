using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.AgencyBank.Queries.GetAgnecyBankByIdQuerie;


internal class GetAgencyBankByIdQueryHandler :IRequestHandler<GetAgencyBankByIdQuery, OperationResult<GetByIdQueryResult>>
{
    
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAgencyBankByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<GetByIdQueryResult>> Handle(GetAgencyBankByIdQuery request, CancellationToken cancellationToken)
    {
        var agencyBank = await _unitOfWork.AgencyBankRepository.GetTrAgencyBankById(request.codeAgBq);

        var result =   _mapper.Map<TR_Ag_Bq, GetByIdQueryResult>(agencyBank);

        return OperationResult<GetByIdQueryResult>.SuccessResult(result);
    }
}