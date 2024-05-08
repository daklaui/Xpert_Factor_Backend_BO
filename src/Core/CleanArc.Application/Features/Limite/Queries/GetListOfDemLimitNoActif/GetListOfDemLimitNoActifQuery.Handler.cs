using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Limite.Queries;

internal class getListOfDemLimitNoActif_Handler : IRequestHandler<getListOfDemLimitNoActifQuery, OperationResult<PageInfo<getListOfDemLimitNoActif_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public getListOfDemLimitNoActif_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<getListOfDemLimitNoActif_Response>>> Handle(getListOfDemLimitNoActifQuery request, CancellationToken cancellationToken)
    {
        var limite = await _unitOfWork.LimiteRepository.getListOfDemLimitNoActif(request.paginationParams);
       
        var result = new PageInfo<getListOfDemLimitNoActif_Response>()
        {
            PageSize = limite.PageSize,
            CurrentPage = limite.CurrentPage,
            TotalPages = limite.TotalPages,
            TotalCount = limite.TotalCount,
            Result = limite.Select(_mapper.Map<T_DEM_LIMITE_DTO, getListOfDemLimitNoActif_Response>).ToList()

        };
        return OperationResult<PageInfo<getListOfDemLimitNoActif_Response>>.SuccessResult(result);

    }
}