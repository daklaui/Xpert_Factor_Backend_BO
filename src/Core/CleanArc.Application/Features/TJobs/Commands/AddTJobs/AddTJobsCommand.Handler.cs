using Mediator;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.TJobs.Commands;
using CleanArc.Application.Features.TJobs.TJobs.Commands.AddTJobs;
using CleanArc.Application.Models.Common;

namespace CleanArc.Application.Features.TJobs.Commands.AddTJobs
{
    public class AddTJobsCommandHandler : IRequestHandler<AddTJobsCommand, OperationResult<bool>>
    {
        private readonly ITJobsRepository _tJobsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AddTJobsCommandHandler(ITJobsRepository tJobsRepository, IUnitOfWork unitOfWork)
        {
            _tJobsRepository = tJobsRepository;
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddTJobsCommand request, CancellationToken cancellationToken)
        {
            await _tJobsRepository.AddTJobsAsync(request.ActprofBct);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
    }
}
