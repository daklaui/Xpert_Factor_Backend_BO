using CleanArc.Application.Contracts.Identity;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TjDocumentDetBord.Commands.AddTjDocumentCommand;

public class AddTjDocumentCommandHandler : IRequestHandler<AddTjDocumentCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAppUserManager _userManager;

    public AddTjDocumentCommandHandler(IUnitOfWork unitOfWork, IAppUserManager userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }
    public async ValueTask<OperationResult<bool>> Handle(AddTjDocumentCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.TjDocumentDetBordRepository.addTj_documentAsync(request.TjDocumentDetBord);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}