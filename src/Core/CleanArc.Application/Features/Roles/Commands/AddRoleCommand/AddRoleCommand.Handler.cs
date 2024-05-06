using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Roles.Commands.AddRoleCommand
{
    public class AddRoleCommandHandler : IRequestHandler<AddRoleCommand, OperationResult<bool>>
    {
        
        private readonly IUnitOfWork _unitOfWork;

        public AddRoleCommandHandler(IRolesRepository rolesRepository, IUnitOfWork unitOfWork)
        {
            
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddRoleCommand request, CancellationToken cancellationToken)
        {
            try
            {
                
                await _unitOfWork.RolesRepository.AddRoleAsync(request.Role);
                await _unitOfWork.CommitAsync();

                return OperationResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                // Log the exception details
                return OperationResult<bool>.FailureResult($"Failed to add role. Error: {ex.Message}");
            }
        }
    }
}