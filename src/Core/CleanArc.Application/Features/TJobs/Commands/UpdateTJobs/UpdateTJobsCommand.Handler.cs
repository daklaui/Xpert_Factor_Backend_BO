using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;
using System;
using System.Threading;
using System.Threading.Tasks;
using CleanArc.Application.Features.TJobs.Commands;

namespace CleanArc.Application.Features.TJobs.Commands.UpdateTJobs
{
    public class UpdateTJobsCommandHandler : IRequestHandler<UpdateTJobsCommand, OperationResult<Unit>>
    {
        private readonly ITJobsRepository _tJobsRepository;
        private readonly IMapper _mapper;

        public UpdateTJobsCommandHandler(ITJobsRepository tJobsRepository, IMapper mapper)
        {
            _tJobsRepository = tJobsRepository ?? throw new ArgumentNullException(nameof(tJobsRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async ValueTask<OperationResult<Unit>> Handle(UpdateTJobsCommand request, CancellationToken cancellationToken)
        {
            var existingTJobs = await _tJobsRepository.GetTJobsById(request.Id);

            if (existingTJobs == null)
            {
                return OperationResult<Unit>.FailureResult($"TJobs with id {request.Id} not found.");
            }

            _mapper.Map(request, existingTJobs);

            try
            {
                await _tJobsRepository.UpdateTJobsAsync(existingTJobs.Id, existingTJobs);

                return OperationResult<Unit>.SuccessResult(Unit.Value);
            }
            catch (Exception ex)
            {
                return OperationResult<Unit>.FailureResult($"Error updating TJobs: {ex.Message}");
            }
        }
    }
}
