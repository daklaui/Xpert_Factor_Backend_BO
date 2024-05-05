using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities.DTO;
using Mediator;
using NuGet.Protocol.Plugins;

namespace CleanArc.Application.Features.RecouvrementList.Queries.GetAllRecouvrement;

internal class GetAllRecouvrementFacturesQuery_Handler : IRequestHandler<GetAllRecouvrementFacturesQuery,
    OperationResult<PageInfo<GetAllRecouvrementFacturesQuery_Response>>>
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllRecouvrementFacturesQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<GetAllRecouvrementFacturesQuery_Response>>> Handle(
        GetAllRecouvrementFacturesQuery request, CancellationToken cancellationToken)
    {
        var recouvListe = await _unitOfWork.EncaissementRepository.GetAllRecouvrementFactures();
        var result = new PageInfo<GetAllRecouvrementFacturesQuery_Response>()
        {
            PageSize = recouvListe.Count,
            CurrentPage = 1,
            TotalPages = 1,
            TotalCount = recouvListe.Count,
            Result = recouvListe.Select(_mapper.Map<T_RECOUVREMENT_DTO, GetAllRecouvrementFacturesQuery_Response>).ToList()
        };
        return OperationResult<PageInfo<GetAllRecouvrementFacturesQuery_Response>>.SuccessResult(result);

    }
}
