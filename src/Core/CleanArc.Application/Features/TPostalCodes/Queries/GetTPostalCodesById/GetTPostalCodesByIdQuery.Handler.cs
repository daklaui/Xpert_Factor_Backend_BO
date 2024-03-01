using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using Mediator;
using System.Threading;
using System.Threading.Tasks;

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
            var tPostalCodes = await _unitOfWork.TPostalCodesRepository.GetTPostalCodesById(request.TPostalCodesId);

            if (tPostalCodes == null)
            {
                return OperationResult<GetByIdQueryResult>.FailureResult($"TPostalCodes with id {request.TPostalCodesId} not found.");
            }

            var result = _mapper.Map<Domain.Entities.TPostalCodes, GetByIdQueryResult>(tPostalCodes);

            return OperationResult<GetByIdQueryResult>.SuccessResult(result);
        }
    }
}
