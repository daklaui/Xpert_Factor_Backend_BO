using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;


namespace CleanArc.Application.Features.TJob.Queries.GetAllTJobs;

internal class GetAllTJobsQuery_Handler:IRequestHandler<GetAllTJobsQuery,OperationResult<List<GetAllTJobsQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllTJobsQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<List<GetAllTJobsQuery_Response>>> Handle(GetAllTJobsQuery request, CancellationToken cancellationToken)
    {
        var tJobs = await _unitOfWork.TJobsRepository.GetAllTJobsAsync();

        var response = tJobs.Select(_mapper.Map<TR_ACTPROF_BCT, GetAllTJobsQuery_Response>).ToList();

        return OperationResult<List<GetAllTJobsQuery_Response>>.SuccessResult(response);
    }
}

