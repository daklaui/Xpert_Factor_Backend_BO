using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ListValue.Queries.GetAllListValues
{
    internal class GetAllListValuesQueryHandler : IRequestHandler<GetAllListValuesQuery, OperationResult<PageInfo<GetAllListValuesQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllListValuesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetAllListValuesQueryResult>>> Handle(GetAllListValuesQuery request, CancellationToken cancellationToken)
        {
            var listValues = await _unitOfWork.ListValueRepository.GetAllListValuesAsync(request.paginationParams);

            var result = new PageInfo<GetAllListValuesQueryResult>
            {
                PageSize = listValues.PageSize,
                CurrentPage = listValues.CurrentPage,
                TotalPages = listValues.TotalPages,
                TotalCount = listValues.TotalCount,
                Result = listValues.Select(_mapper.Map<TR_LIST_VAL, GetAllListValuesQueryResult>).ToList()
            };

            return OperationResult<PageInfo<GetAllListValuesQueryResult>>.SuccessResult(result);
        }
    }
}
