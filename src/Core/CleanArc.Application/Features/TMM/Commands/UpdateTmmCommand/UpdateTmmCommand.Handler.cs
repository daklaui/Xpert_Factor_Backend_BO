using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TMM.Commands.UpdateTmmCommand;


internal class UpdateTmmCommandHandler :IRequestHandler<UpdateTmmCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateTmmCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(UpdateTmmCommand request, CancellationToken cancellationToken)
    {
        var tmm = await _unitOfWork.TmmRepository.GetTrTmmById(request.ID_TMM);

        if (tmm == null)
        {
            return OperationResult<bool>.FailureResult("tmm not found");
        }

        tmm.TAUX_TMM= request.TAUX_TMM;
        tmm.DATE_FIN_TMM = request.DATE_FIN_TMM;
        tmm.DATE_DEBUT_TMM = request.DATE_DEBUT_TMM;

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }

}
