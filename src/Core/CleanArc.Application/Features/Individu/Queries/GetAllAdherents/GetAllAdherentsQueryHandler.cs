using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using Mediator;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CleanArc.Application.Features.Individu.Queries.GetAllAdherents;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;

namespace CleanArc.Application.Features.Individu.Queries.GetAllAdherents;
internal class GetAllAdherentsQueryHandler : IRequestHandler<GetAllAdherentsQuery, OperationResult<List<AdherentDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllAdherentsQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<List<AdherentDto>>> Handle(GetAllAdherentsQuery request, CancellationToken cancellationToken)
    {
        var adherents = await _unitOfWork.IndividualRepository.GetAllAdherentsAsync();
        Console.WriteLine($"Adherents count: {adherents.Count}");
        return OperationResult<List<AdherentDto>>.SuccessResult(adherents);
    }
}
