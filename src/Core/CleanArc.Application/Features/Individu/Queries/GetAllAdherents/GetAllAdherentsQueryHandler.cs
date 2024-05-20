using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllAdherents;

internal class GetAllAdherentsQueryHandler : IRequestHandler<GetAllAdherentsQuery, OperationResult<List<string>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllAdherentsQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async ValueTask<OperationResult<List<string>>> Handle(GetAllAdherentsQuery request, CancellationToken cancellationToken)
    {
        var adherents = await _unitOfWork.IndividualRepository.GetAllAdherentsAsync();

        return OperationResult<List<string>>.SuccessResult(adherents);
    }
}