using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllNomIndiv;

internal class GetAllNomIndivQueryHandler:  IRequestHandler<GetAllNomIndivQuery, OperationResult<List<NomIndividuDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;


    public GetAllNomIndivQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
      
    }


    public async ValueTask<OperationResult<List<NomIndividuDto>>> Handle(GetAllNomIndivQuery request, CancellationToken cancellationToken)
    {
        var nomIndividuDtos = await _unitOfWork.IndividualRepository.GetAllNomIndivAsync();
        Console.WriteLine($"Adherents count: {nomIndividuDtos.Count}");
        return OperationResult<List<NomIndividuDto>>.SuccessResult(nomIndividuDtos);
    }
}