using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Queries.GetPostsList

{ 
    internal class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery,OperationResult<PageInfo<GetPostsListQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetPostsListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetPostsListQueryResult>>> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var list = await _unitOfWork.CpRepository.GetPostsList(request.paginationParams);
 
            var result = new PageInfo<GetPostsListQueryResult>
            {
                PageSize = list.PageSize,
                CurrentPage = list.CurrentPage,
                TotalPages = list.TotalPages,
                TotalCount = list.TotalCount,
                Result = list.Select(_mapper.Map<TR_CP, GetPostsListQueryResult>).ToList()

            };
            return OperationResult<PageInfo<GetPostsListQueryResult>>.SuccessResult(result);
        }
    }
}