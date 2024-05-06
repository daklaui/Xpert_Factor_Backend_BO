using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Permissions.Commands.AddPermissionCommand;

public class AddPermissionCommandHandler : IRequestHandler<AddPermissionCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddPermissionCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddPermissionCommand request, CancellationToken cancellationToken)
    {
        try
        {
            await _unitOfWork.PermissionRepository.AddPermissionAsync(request.Permission);
            await _unitOfWork.CommitAsync();

            return OperationResult<bool>.SuccessResult(true);
        }
        catch (Exception ex)
        {
            // Log the exception details
            return OperationResult<bool>.FailureResult("Failed to add permission. Error: " + ex.Message);
        }
    }
}