using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAcheteurPourContrat;

internal class GetAcheteurPourContrat_Handler:IRequestHandler<GetAcheteurPourContratQuery,OperationResult<List<NomIndividuDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAcheteurPourContrat_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    } 
    public async ValueTask<OperationResult<List<NomIndividuDto>>> Handle(GetAcheteurPourContratQuery request, CancellationToken cancellationToken)
        {
           
            var individus = await _unitOfWork.IndividualRepository.GetAcheteurPourContrat(request.refctr);
            Console.WriteLine($"Adherents count: {individus.Count}");
            return OperationResult<List<NomIndividuDto>>.SuccessResult(individus);
        }
}