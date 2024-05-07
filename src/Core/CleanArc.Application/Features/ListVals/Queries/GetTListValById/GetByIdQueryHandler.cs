using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TListVal.Queries.GetByIdQuery
{
    internal class GetByIdQueryHandler : IRequestHandler<GetTListValByIdQuery, OperationResult<GetByIdQueryResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<GetByIdQueryResult>> Handle(GetTListValByIdQuery request, CancellationToken cancellationToken)
        {
            var listVal = await _unitOfWork.TListValRepository.GetTListValById(request.tListValId);

            var result = _mapper.Map<TR_LIST_VAL, GetByIdQueryResult>(listVal);

            return OperationResult<GetByIdQueryResult>.SuccessResult(result);
        }
    }
}