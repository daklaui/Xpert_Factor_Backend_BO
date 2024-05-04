using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Recouvrement.Commands.UpdateRecouvrementCommand;

public class UpdateRecouvrementCommandHandler: IRequestHandler<UpdateRecouvrementCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateRecouvrementCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<bool>> Handle(UpdateRecouvrementCommand request,
        CancellationToken cancellationToken)
    {
        try
        {
            var existingRecouvrement = await _unitOfWork.RecouvrementRepository.GetRecouvrementById(
                request.RecouvrementId);
            await _unitOfWork.RecouvrementRepository.UpdateDocumentDetBordAsync(request.RecouvrementId,
                request.UpdatedRecouvrement);
            await _unitOfWork.CommitAsync();

       
            return OperationResult<bool>.SuccessResult(true);
        }
        catch (Exception e)
        {
            return OperationResult<bool>.FailureResult($"Error updating Recouvrement: {e.Message}");
        }
       
    }
}