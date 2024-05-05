using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Queries.GetLangList

{ 
    internal class GetLangListQueryHandler : IRequestHandler<GetLangListQuery,OperationResult<PageInfo<GetLangListQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetLangListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetLangListQueryResult>>> Handle(GetLangListQuery request, CancellationToken cancellationToken)
        {
            var list = await _unitOfWork.ValuesListRepository.GetLangList(request.paginationParams);
 
            var result = new PageInfo<GetLangListQueryResult>
            {
                PageSize = list.PageSize,
                CurrentPage = list.CurrentPage,
                TotalPages = list.TotalPages,
                TotalCount = list.TotalCount,
                Result = list.Select(_mapper.Map<TR_NLDP, GetLangListQueryResult>).ToList()

            };
            return OperationResult<PageInfo<GetLangListQueryResult>>.SuccessResult(result);
        }
    }
}