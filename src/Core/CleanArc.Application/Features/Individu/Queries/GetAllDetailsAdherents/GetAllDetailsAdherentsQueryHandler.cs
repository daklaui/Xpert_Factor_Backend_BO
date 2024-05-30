using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllDetailsAdherents;

public class GetAllDetailsAdherentsQueryHandler:IRequestHandler<GetAllDetailsAdherentsQuery, OperationResult<List<AdherentDetailDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllDetailsAdherentsQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<List<AdherentDetailDto>>> Handle(GetAllDetailsAdherentsQuery request, CancellationToken cancellationToken)
    {
        var adherents =
            await _unitOfWork.IndividualRepository.GetAdherentDetailsByAdherentAsync(request.refIndiv);
       Console.WriteLine($"Adherents count: {adherents.Count}");
        return OperationResult<List<AdherentDetailDto>>.SuccessResult(adherents);
    }
}