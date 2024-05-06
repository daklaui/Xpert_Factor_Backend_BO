using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.DTO;
using Mediator;
using NuGet.Protocol.Plugins;

namespace CleanArc.Application.Features.Litige.Queries.GetAllRapportFacturesEnLitige;

internal class GetAllRapportFacturesEnLitigeQuery_Handler :IRequestHandler<GetAllRapportFacturesEnLitigeQuery,OperationResult<PageInfo<GetAllRapportFacturesEnLitigeQuery_Response>>>
{
    
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllRapportFacturesEnLitigeQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public  async ValueTask<OperationResult<PageInfo<GetAllRapportFacturesEnLitigeQuery_Response>>> Handle(GetAllRapportFacturesEnLitigeQuery request, CancellationToken cancellationToken)
    {
        var impayeDtoList = _unitOfWork.LitigesRepository.GetAllRapportFacturesEnLitige();
        var result = new PageInfo<GetAllRapportFacturesEnLitigeQuery_Response>()
        {
            PageSize = impayeDtoList.Count,
            CurrentPage = 1, 
            TotalPages = 1, 
            TotalCount = impayeDtoList.Count,
            Result = impayeDtoList.Select(_mapper.Map<T_LITIGE_DTO, GetAllRapportFacturesEnLitigeQuery_Response>).ToList()
        };
        return OperationResult<PageInfo<GetAllRapportFacturesEnLitigeQuery_Response>>.SuccessResult(result);
    }
}