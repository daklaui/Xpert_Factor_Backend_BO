using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.GED.Queries;

public class GetAllGEDNumerisationQueryHandler : IRequestHandler<GetAllGEDNumerisationQuery,OperationResult<PageInfo<GetAllGEDNumerisationQueryResult>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllGEDNumerisationQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async ValueTask<OperationResult<PageInfo<GetAllGEDNumerisationQueryResult>>> Handle(GetAllGEDNumerisationQuery request, CancellationToken cancellationToken)
    {
        var GEDNumerisation = await _unitOfWork.GEDRepository.GetAllGEDNumerisationAsync(request.paginationParams);
 
        var result = new PageInfo<GetAllGEDNumerisationQueryResult>
        {
            PageSize = GEDNumerisation.Count,
            CurrentPage = 1,
            TotalPages = 10,
            TotalCount = GEDNumerisation.Count,
            Result = GEDNumerisation.Select(_mapper.Map<GEDNumerisationDTO, GetAllGEDNumerisationQueryResult>).ToList()

        };
        return OperationResult<PageInfo<GetAllGEDNumerisationQueryResult>>.SuccessResult(result);
    }
}