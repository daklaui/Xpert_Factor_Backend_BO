/*using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Queries.GetJobsList

{ 
    internal class GetJobsListQueryHandler : IRequestHandler<GetJobsListQuery,OperationResult<PageInfo<GetJobsListQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetJobsListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetJobsListQueryResult>>> Handle(GetJobsListQuery request, CancellationToken cancellationToken)
        {
            var list = await _unitOfWork.ActProfRepository.GetJobsList(request.paginationParams);
 
            var result = new PageInfo<GetJobsListQueryResult>
            {
                PageSize = list.PageSize,
                CurrentPage = list.CurrentPage,
                TotalPages = list.TotalPages,
                TotalCount = list.TotalCount,
                Result = list.Select(_mapper.Map<TR_ACTPROF_BCT, GetJobsListQueryResult>).ToList()

            };
            return OperationResult<PageInfo<GetJobsListQueryResult>>.SuccessResult(result);
        }
    }
}*/