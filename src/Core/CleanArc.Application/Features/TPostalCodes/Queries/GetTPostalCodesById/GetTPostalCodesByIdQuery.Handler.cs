using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;

using Mediator;

namespace CleanArc.Application.Features.TPostalCodes.Queries.GetTPostalCodesById
{
    internal class GetTPostalCodesByIdQueryHandler : IRequestHandler<GetTPostalCodesByIdQuery, OperationResult<GetByIdQueryResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetTPostalCodesByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<GetByIdQueryResult>> Handle(GetTPostalCodesByIdQuery request, CancellationToken cancellationToken)
        {
            var trCp = await _unitOfWork.TPostalCodesRepository.GetTPostalCodesById(request.TPostalCodesId);

            if (trCp == null)
            {
                return OperationResult<GetByIdQueryResult>.FailureResult($"TPostalCodes with id {request.TPostalCodesId} not found.");
            }

            var result = _mapper.Map<Domain.Entities.TR_CP, GetByIdQueryResult>(trCp);

            return OperationResult<GetByIdQueryResult>.SuccessResult(result);
        }
    }
}
