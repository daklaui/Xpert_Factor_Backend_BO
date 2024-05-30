using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.buyer.Commands.Queries;

internal class GetAcheteursByContratQueryHandler : IRequestHandler<GetAcheteursByContratQuery, OperationResult<List<AcheteurDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAcheteursByContratQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<List<AcheteurDto>>> Handle(GetAcheteursByContratQuery request, CancellationToken cancellationToken)
    {
        var acheteurs = await _unitOfWork.tjcirRepository.GetAcheteursByContratAsync(request.RefCtrCir);
        return OperationResult<List<AcheteurDto>>.SuccessResult(acheteurs);
    }
}