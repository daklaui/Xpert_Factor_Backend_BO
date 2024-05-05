using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Application.Common;
using CleanArc.Domain.Entities;
using Mediator;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArc.Application.Features.TJobs.Queries.GetTJobsById
{
    internal class GetTJobByIdQueryHandler : IRequestHandler<GetTJobsByIdQuery, OperationResult<GetTJobsByIdQueryResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetTJobByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<GetTJobsByIdQueryResult>> Handle(GetTJobsByIdQuery request, CancellationToken cancellationToken)
        {
            var actprofBcts = await _unitOfWork.TJobsRepository.GetTJobsById(request.TJobsId);

            if (actprofBcts == null)
            {
                return OperationResult<GetTJobsByIdQueryResult>.FailureResult($"TJob with id {request.TJobsId} not found.");
            }

            var result = _mapper.Map<Domain.Entities.TR_ACTPROF_BCT, GetTJobsByIdQueryResult>(actprofBcts);

            return OperationResult<GetTJobsByIdQueryResult>.SuccessResult(result);
        }
    }
}
