using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Financement.Commands.AddFinancementCommand
{
 internal class AddFinancementCommandHandler : IRequestHandler<AddFinancementCommand, OperationResult<bool>>
 {
  private readonly IUnitOfWork _unitOfWork;

  public AddFinancementCommandHandler(IUnitOfWork unitOfWork)
  {
   _unitOfWork = unitOfWork;
  }

  public async ValueTask<OperationResult<bool>> Handle(AddFinancementCommand request, CancellationToken cancellationToken)
  {
   await _unitOfWork.FinancementRepository.AddFinancementAsync(request.financement);

   await _unitOfWork.CommitAsync();

   return OperationResult<bool>.SuccessResult(true);
  }
 }
}