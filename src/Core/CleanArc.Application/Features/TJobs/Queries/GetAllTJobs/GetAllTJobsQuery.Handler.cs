using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArc.Application.Features.TJobs.Queries.GetAllTJobs
{
    internal class GetAllTJobsQueryHandler : IRequestHandler<GetAllTJobsQuery, OperationResult<PageInfo<GetAllTJobsQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTJobsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async ValueTask<OperationResult<PageInfo<GetAllTJobsQueryResult>>> Handle(GetAllTJobsQuery request, CancellationToken cancellationToken)
        {
            var actprofBcts = await _unitOfWork.TJobsRepository.GetAllTJobsAsync(request.PaginationParams);

            if (actprofBcts == null)
            {
                return OperationResult<PageInfo<GetAllTJobsQueryResult>>.FailureResult("Failed to retrieve TJobs");
            }

            var result = new PageInfo<GetAllTJobsQueryResult>
            {
                PageSize = actprofBcts.PageSize,
                CurrentPage = actprofBcts.CurrentPage,
                TotalPages = actprofBcts.TotalPages,
                TotalCount = actprofBcts.TotalCount,
                Result = actprofBcts.Select(_mapper.Map<Domain.Entities.TR_ACTPROF_BCT, GetAllTJobsQueryResult>).ToList()
            };

            return OperationResult<PageInfo<GetAllTJobsQueryResult>>.SuccessResult(result);
        }
    }
}
