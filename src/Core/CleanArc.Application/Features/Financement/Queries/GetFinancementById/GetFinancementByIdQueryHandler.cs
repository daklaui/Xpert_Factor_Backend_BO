using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Financement.Queries
{

    internal  class GetFinancementByIdQueryHandler : IRequestHandler <GetFinancementByIdQuery,OperationResult<GetFinancementByIdQueryResult>>
    {
        
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetFinancementByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<GetFinancementByIdQueryResult>> Handle(GetFinancementByIdQuery request, CancellationToken cancellationToken)
        {
            var financement = await  _unitOfWork.FinancementRepository.GetFinancementById(request.id);

            var result =   _mapper.Map<T_FINANCEMENT, GetFinancementByIdQueryResult>(financement);

            return OperationResult<GetFinancementByIdQueryResult>.SuccessResult(result);
        }
    }
}