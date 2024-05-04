using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Infrastructure.Identity.Identity.Dtos;
using Mediator; 

namespace CleanArc.Application.Features.Financement.Queries
{

    internal  class GetFinancementRefCtrHandler : IRequestHandler <GetFundingByRefCtrQuery,OperationResult<GetFinancementRefCtrQueryResult>>
    {
        
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetFinancementRefCtrHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
    
       
        public async ValueTask<OperationResult<GetFinancementRefCtrQueryResult>> Handle(GetFundingByRefCtrQuery request, CancellationToken cancellationToken)
        {
          

            var financement = await  _unitOfWork.FundingRepository.AllRecord(request.id);

            var result =   _mapper.Map<FinancementDto, GetFinancementRefCtrQueryResult>(financement);

            return OperationResult<GetFinancementRefCtrQueryResult>.SuccessResult(result);
        }
    }

}