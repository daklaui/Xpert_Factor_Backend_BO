using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TJob.Commands.AddTJob;

internal class AddTJobCommand_Handler:IRequestHandler<AddTJobCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddTJobCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public  async ValueTask<OperationResult<bool>> Handle(AddTJobCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.TJobsRepository.AddTJobsAsync(request.actprofBct);
        await _unitOfWork.CommitAsync();
        return OperationResult<bool>.SuccessResult(true);
    }
}