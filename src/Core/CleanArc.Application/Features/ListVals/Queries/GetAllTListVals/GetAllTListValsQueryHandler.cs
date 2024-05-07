using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;


namespace CleanArc.Application.Features.TListVal.Queries.GetAllTListVals
{
    internal class GetAllTListValsQueryHandler : IRequestHandler<GetAllTListValsQuery, OperationResult<PageInfo<GetAllTListValsQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTListValsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetAllTListValsQueryResult>>> Handle(GetAllTListValsQuery request, CancellationToken cancellationToken)
        {
            if (_unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(_unitOfWork), "UnitOfWork is null");
            }

            if (_mapper == null)
            {
                throw new ArgumentNullException(nameof(_mapper), "Mapper is null");
            }

            var listVal = await _unitOfWork.TListValRepository.GetAllTListValsAsync(request.PaginationParams);

            if (listVal == null)
            {
                return OperationResult<PageInfo<GetAllTListValsQueryResult>>.FailureResult("Failed to retrieve TListVals");
            }

            var result = new PageInfo<GetAllTListValsQueryResult>
            {
                PageSize = listVal.PageSize,
                CurrentPage = listVal.CurrentPage,
                TotalPages = listVal.TotalPages,
                TotalCount = listVal.TotalCount,
                Result = listVal.Select(_mapper.Map<TR_LIST_VAL, GetAllTListValsQueryResult>).ToList()
            };

            return OperationResult<PageInfo<GetAllTListValsQueryResult>>.SuccessResult(result);
        }



    }
}