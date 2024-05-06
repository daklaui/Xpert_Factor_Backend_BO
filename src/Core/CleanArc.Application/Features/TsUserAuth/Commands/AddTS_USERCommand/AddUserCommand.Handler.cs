using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TsUserAuth.Commands.AddTS_USERCommand;

public class AddUserCommandHandler : IRequestHandler<AddUserCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddUserCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            await _unitOfWork.UserRepository.AddUserAsync(request.User);
            await _unitOfWork.CommitAsync();

            return OperationResult<bool>.SuccessResult(true);
        }
        catch (Exception ex)
        {
            // Log the exception details
            return OperationResult<bool>.FailureResult("Failed to add user. Error: " + ex.Message);
        }
    }
}