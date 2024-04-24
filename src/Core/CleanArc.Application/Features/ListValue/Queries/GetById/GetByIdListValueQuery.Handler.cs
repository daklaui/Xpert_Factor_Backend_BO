using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ListValue.Queries.GetById
{
    internal class GetByIdListValueQueryHandler : IRequestHandler<GetByIdListValueQuery, OperationResult<GetByIdListValueQueryResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByIdListValueQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<GetByIdListValueQueryResult>> Handle(GetByIdListValueQuery request, CancellationToken cancellationToken)
        {
            var listValue = await _unitOfWork.ListValueRepository.GetListValueById(request.ListValueId);

            var result = _mapper.Map<TR_LIST_VAL, GetByIdListValueQueryResult>(listValue);

            return OperationResult<GetByIdListValueQueryResult>.SuccessResult(result);
        }
    }
}
