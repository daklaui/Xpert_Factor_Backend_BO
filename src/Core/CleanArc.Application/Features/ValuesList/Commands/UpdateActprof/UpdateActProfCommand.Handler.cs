/*
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Commands.UpdateActprof;

internal class UpdateActprofCommandHandler :IRequestHandler<UpdateActprofCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateActprofCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(UpdateActprofCommand request, CancellationToken cancellationToken)
    {
        var actprofBct = await _unitOfWork.ActProfRepository.GetJobsList(request.Code_SousClasse);

        if (actprofBct == null)
        {
            return OperationResult<bool>.FailureResult("actprofBct not found");
        }

        actprofBct.Code_Section= request.Code_Section;
        actprofBct.Section = request.Section;
        actprofBct.Code_SousSection = request.Code_SousSection;
        actprofBct.SousSection = request.SousSection;
        actprofBct.Code_Activité = request.Code_Activité;
        actprofBct.Code_Classe = request.Code_Classe;
        actprofBct.Classe = request.Classe;
        actprofBct.Code_Classe1 = request.Code_Classe1;
        actprofBct.Code_SousClasse = request.Code_SousClasse;
        actprofBct.SousClasse = request.SousClasse;
        

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }

}
*/