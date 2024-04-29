using CleanArc.Application.Contracts.Persistence;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.ValidateBordereauCommand;

public class ValidateBordereauCommandHandler : IRequestHandler<ValidateBordereauCommand, bool>
{
    private readonly IUnitOfWork _unitOfWork;

    public ValidateBordereauCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async ValueTask<bool> Handle(ValidateBordereauCommand request, CancellationToken cancellationToken)
    {
        
        var pksDto = request.PksBordereauxDto;
        bool isValidated = await _unitOfWork.BordereauxRepository.ValidateBordereauAsync(pksDto.NUM_BORD,pksDto.REF_CTR_BORD,pksDto.ANNEE_BORD);

       
        return isValidated;
    }
}