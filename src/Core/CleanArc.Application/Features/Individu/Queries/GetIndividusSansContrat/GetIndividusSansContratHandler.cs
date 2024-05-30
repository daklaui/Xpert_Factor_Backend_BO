using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetIndividusSansContrat;

internal class GetIndividusSansContratHandler :IRequestHandler<GetIndividusSansContratQuery,OperationResult<List<NomIndividuDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetIndividusSansContratHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public async ValueTask<OperationResult<List<NomIndividuDto>>> Handle(GetIndividusSansContratQuery request, CancellationToken cancellationToken)
    {
        var individus = await _unitOfWork.IndividualRepository.GetIndividusSansContrat(request.refctr);
        Console.WriteLine($"Adherents count: {individus.Count}");
        return OperationResult<List<NomIndividuDto>>.SuccessResult(individus);
    }
}