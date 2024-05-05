using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;
using NuGet.Protocol.Plugins;

namespace CleanArc.Application.Features.ListVal.Queries.GetAllRecouvrement;

internal class GetAllRecouvrementQuery_Handler : IRequestHandler<GetAllRecouvrementQuery,
    OperationResult<PageInfo<GetAllRecouvrementQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllRecouvrementQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public  async  ValueTask<OperationResult<PageInfo<GetAllRecouvrementQuery_Response>>> Handle(GetAllRecouvrementQuery request, CancellationToken cancellationToken)
    {
        var recouvListe = await _unitOfWork.ListValRepository.GetAllRecouvrementAsync();
        var result = new PageInfo<GetAllRecouvrementQuery_Response>()
        {
            PageSize = recouvListe.Count,
            CurrentPage = 1,
            TotalPages = 1,
            TotalCount = recouvListe.Count,
            Result = recouvListe.Select(_mapper.Map<TR_LIST_VAL, GetAllRecouvrementQuery_Response>).ToList()
        };
        return OperationResult<PageInfo<GetAllRecouvrementQuery_Response>>.SuccessResult(result);

    }
}