using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TJob.Queries.GetTJobsByIdQuery;

internal class GetTJobsById_Handler:IRequestHandler<GetTJobsByIdQuery,OperationResult<GetTJobsById_Response>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetTJobsById_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<GetTJobsById_Response>> Handle(GetTJobsByIdQuery request, CancellationToken cancellationToken)
    {
        var job = await _unitOfWork.TJobsRepository.GetTJobsById(request.code);

        var result =   _mapper.Map<TR_ACTPROF_BCT, GetTJobsById_Response>(job);

        return OperationResult<GetTJobsById_Response>.SuccessResult(result);
    }
}