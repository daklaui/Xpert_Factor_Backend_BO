using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TJob.Commands.UpdateTJobCommand;

public class UpdateTJobsCommand_Handler:IRequestHandler<UpdateTJobsCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateTJobsCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(UpdateTJobsCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.TJobsRepository.UpdateTJobsAsync(request.code,request.Bct);
        await _unitOfWork.CommitAsync();
        return OperationResult<bool>.SuccessResult(true);    }
}