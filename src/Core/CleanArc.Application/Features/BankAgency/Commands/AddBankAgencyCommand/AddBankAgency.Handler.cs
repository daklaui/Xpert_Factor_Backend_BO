using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.BankAgency.Commands.AddBankAgencyCommand
{


    internal class AddAgBqCommandHandler : IRequestHandler<AddAgBqCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;


        public AddAgBqCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(AddAgBqCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.AgBqRepository.AddAgBqAsync(request.AgBq);

            await _unitOfWork.CommitAsync();

            return OperationResult<bool>.SuccessResult(true);
        }
    }
    
    
    
    
    
    
    
    
    
}
