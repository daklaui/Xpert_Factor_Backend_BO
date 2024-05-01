using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using CleanArc.Application.Contracts.Persistence;
using AutoMapper;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Queries.GetContratByIdQuery
{
    internal class GetContratByIdQueryHandler : IRequestHandler<GetContratByIdQuery, OperationResult<GetContratByIdQueryResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetContratByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<GetContratByIdQueryResult>> Handle(GetContratByIdQuery request, CancellationToken cancellationToken)
        {
            var contrat = await _unitOfWork.ContratRepository.GetContratById(request.contratId);

            if (contrat == null)
            {
                return OperationResult<GetContratByIdQueryResult>.FailureResult($"Contrat with id {request.contratId} not found.");
            }

            var result = _mapper.Map<T_CONTRAT, GetContratByIdQueryResult>(contrat);

            return OperationResult<GetContratByIdQueryResult>.SuccessResult(result);
        }
    }
}
