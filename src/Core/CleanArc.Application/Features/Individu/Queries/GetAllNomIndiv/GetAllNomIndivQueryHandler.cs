using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetAllNomIndiv;

internal class GetAllNomIndivQueryHandler:  IRequestHandler<GetAllNomIndivQuery, OperationResult<PageInfo<GetAllNomIndiQueryResult>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;


    public GetAllNomIndivQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async ValueTask<OperationResult<PageInfo<GetAllNomIndiQueryResult>>> Handle(GetAllNomIndivQuery request, CancellationToken cancellationToken)
    {
        var individus = await _unitOfWork.IndividualRepository.GetAllNomIndivAsync(request.PaginationParams);
        var result = new PageInfo<GetAllNomIndiQueryResult>
        {
            PageSize = individus.PageSize,
            CurrentPage = individus.CurrentPage,
            TotalPages = individus.TotalPages,
            TotalCount = individus.TotalCount,
            Result = individus.Select(ind => new GetAllNomIndiQueryResult { RefInd = ind.RefInd, NomInd = ind.NomInd }).ToList()
        };

        return OperationResult<PageInfo<GetAllNomIndiQueryResult>>.SuccessResult(result);
    }
    
}