using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;


namespace CleanArc.Application.Features.TJob.Queries.GetAllTJobs;

internal class GetAllTJobsQuery_Handler:IRequestHandler<GetAllTJobsQuery,OperationResult<PageInfo<GetAllTJobsQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllTJobsQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<GetAllTJobsQuery_Response>>> Handle(GetAllTJobsQuery request, CancellationToken cancellationToken)
    {
        var Jobs = await _unitOfWork.TJobsRepository.GetAllTJobsAsync(request.PaginationParams);
 
        var result = new PageInfo<GetAllTJobsQuery_Response>
        {
            PageSize =  Jobs.PageSize,
            CurrentPage =  Jobs.CurrentPage,
            TotalPages =  Jobs.TotalPages,
            TotalCount =  Jobs.TotalCount,
            Result =  Jobs.Select(_mapper.Map<TR_ACTPROF_BCT ,GetAllTJobsQuery_Response>).ToList()

        };
        return OperationResult<PageInfo<GetAllTJobsQuery_Response>>.SuccessResult(result);
    }
}

