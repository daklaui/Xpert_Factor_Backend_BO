using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.Individu.Queries.GetAllIndividus;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.RIB.Queries.GetAllRibsByIndividuQueries;

public class GetAllRibsByIndividuQuery_Handler: IRequestHandler<GetAllRibsByIndividuQuery,OperationResult<PageInfo<GetAllRibsByIndividuQueryResult>>>
{
    
    
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllRibsByIndividuQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async ValueTask<OperationResult<PageInfo<GetAllRibsByIndividuQueryResult>>> Handle(GetAllRibsByIndividuQuery request, CancellationToken cancellationToken)
    {
        var  rib = await _unitOfWork.ribRepository.GetAllRibsByIndividuAsync(request.refIndRib,request.PaginationParams);
 
        var result = new PageInfo<GetAllRibsByIndividuQueryResult>
        {
            PageSize = rib.PageSize,
            CurrentPage = rib.CurrentPage,
            TotalPages = rib.TotalPages,
            TotalCount = rib.TotalCount,
            Result = rib.Select(_mapper.Map<TR_RIB, GetAllRibsByIndividuQueryResult>).ToList()

        };
        return OperationResult<PageInfo<GetAllRibsByIndividuQueryResult>>.SuccessResult(result);
    }
    }
