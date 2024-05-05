using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Queries.GetFromJuridiqueList

{ 
    internal class GetFromJuridiqueListQueryHandler : IRequestHandler<GetFromJuridiqueListQuery,OperationResult<PageInfo<GetFromJuridiqueListQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetFromJuridiqueListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetFromJuridiqueListQueryResult>>> Handle(GetFromJuridiqueListQuery request, CancellationToken cancellationToken)
        {
            var list = await _unitOfWork.ValuesListRepository.GetFormJuridiqueList(request.paginationParams);
 
            var result = new PageInfo<GetFromJuridiqueListQueryResult>
            {
                PageSize = list.PageSize,
                CurrentPage = list.CurrentPage,
                TotalPages = list.TotalPages,
                TotalCount = list.TotalCount,
                Result = list.Select(_mapper.Map<TR_LIST_VAL, GetFromJuridiqueListQueryResult>).ToList()

            };
            return OperationResult<PageInfo<GetFromJuridiqueListQueryResult>>.SuccessResult(result);
        }
    }
}