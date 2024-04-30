using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.DTO;
using Mediator;

namespace CleanArc.Application.Features.RIB.Commands.EditRibIndividuCommand;

internal class EditRibIndividuCommand_Handler: IRequestHandler<EditRibIndividuCommand, OperationResult<Unit>>
{
    
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;


    public EditRibIndividuCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<Unit>> Handle(EditRibIndividuCommand request, CancellationToken cancellationToken)
    {
        var ribDto = new TR_RIB_DTO()
        {
            RIB_RIB1 = request.RIB_RIB1,
            RIB_RIB2 = request.RIB_RIB2,
            RIB_RIB3 = request.RIB_RIB3,
            REF_IND_RIB = request.REF_IND_RIB,
            ACTIF_RIB = request.ACTIF_RIB,
            OLD_RIB_RIB = request.OLD_RIB_RIB
        };

        var result = await _unitOfWork.ribRepository.EditRibIndividu(ribDto);

        if (result.Success)
        {
            await _unitOfWork.CommitAsync();
            return OperationResult<Unit>.SuccessResult(Unit.Value);
        }
        else
        {
            await _unitOfWork.RollBackAsync();
            return OperationResult<Unit>.FailureResult(result.Message);
        }
    }
}