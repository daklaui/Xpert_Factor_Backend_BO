using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TR_CP.Queries.GetById
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
            var trCp = await _unitOfWork.TR_CPRepository.GetTR_CPById(request.trCpId);

            var result = _mapper.Map<Domain.Entities.TR_CP, GetByIdQueryResult>(trCp);

            return OperationResult<GetByIdQueryResult>.SuccessResult(result);
        }
    }
}