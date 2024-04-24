using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.FactoringCommission.Queries.GetByIdQuery
{
    internal class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, OperationResult<GetByIdQueryResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<GetByIdQueryResult>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var factoringCommission = await _unitOfWork.FactoringCommissionRepository.GetFactoringCommissionById(request.factoringCommissionId);

            if (factoringCommission == null)
            {
                return OperationResult<GetByIdQueryResult>.FailureResult($"Factoring commission with id {request.factoringCommissionId} not found.");
            }

            var result = _mapper.Map<T_COMM_FACTORING, GetByIdQueryResult>(factoringCommission);

            return OperationResult<GetByIdQueryResult>.SuccessResult(result);
        }
    }
}
