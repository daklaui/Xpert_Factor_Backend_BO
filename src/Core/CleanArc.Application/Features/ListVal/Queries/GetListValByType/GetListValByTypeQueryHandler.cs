using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.ListVal.Queries.GetAllTListVals;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Queries.GetListValByType
{
    internal class GetListValByTypeQueryHandler : IRequestHandler<GetListValByTypeQuery, OperationResult<List<GetListValByTypeQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetListValByTypeQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<List<GetListValByTypeQueryResult>>> Handle(GetListValByTypeQuery request, CancellationToken cancellationToken)
        {
            if (_unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(_unitOfWork), "UnitOfWork is null");
            }

            if (_mapper == null)
            {
                throw new ArgumentNullException(nameof(_mapper), "Mapper is null");
            }

            var listVal = await _unitOfWork.ListValRepository.GetAllTListValsByTypeAsync(request.type);

            if (listVal == null)
            {
                return OperationResult<List<GetListValByTypeQueryResult>>.FailureResult("Failed to retrieve TListVals");
            }

            var result = listVal.Select(_mapper.Map<TR_LIST_VAL, GetListValByTypeQueryResult>).ToList();

            return OperationResult<List<GetListValByTypeQueryResult>>.SuccessResult(result);
        }



    }
}