using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

using NuGet.Protocol.Plugins;

namespace CleanArc.Application.Features.Profil.Commands;

internal class AddProfilCommand_Handler: IRequestHandler<AddProfilCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddProfilCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public async ValueTask<OperationResult<bool>> Handle(AddProfilCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.ProfilRepository.AddProfileAsync(request.profil);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}