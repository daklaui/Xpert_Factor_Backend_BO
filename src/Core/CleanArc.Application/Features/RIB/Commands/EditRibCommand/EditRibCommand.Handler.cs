
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.RIB.Commands.EditRibIndividuCommand;
using CleanArc.Application.Models.Common;
using Mediator;


internal class EditRibCommand_Handler : IRequestHandler<EditRibCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public EditRibCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(EditRibCommand request, CancellationToken cancellationToken)
    {
 
        var existingRib = await _unitOfWork.ribRepository.GetRibById(request.rib.ID_RIB);


        if (existingRib == null)
        {
            return OperationResult<bool>.FailureResult($"RIB avec ID {request.rib.ID_RIB} n'existe pas.");
        }

       
       
            await _unitOfWork.ribRepository.EditRibIndividu(existingRib.ID_RIB, request.rib);
        
            await _unitOfWork.CommitAsync();

        
            return OperationResult<bool>.SuccessResult(true);
       
       
    }

}

