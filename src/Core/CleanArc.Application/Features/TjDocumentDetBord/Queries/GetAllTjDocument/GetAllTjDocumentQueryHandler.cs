using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TjDocumentDetBord.Queries.GetAllTjDocument;

public class GetAllTjDocumentQueryHandler : IRequestHandler<GetAllTjDocumentQuery,OperationResult<PageInfo<GetAllTjDocumentQueryResult>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllTjDocumentQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async ValueTask<OperationResult<PageInfo<GetAllTjDocumentQueryResult>>> Handle(GetAllTjDocumentQuery request, CancellationToken cancellationToken)
    {
        var TjDocument = await _unitOfWork.TjDocumentDetBordRepository.GetAllTj_documentAsync(request.paginationParams);
 
        var result = new PageInfo<GetAllTjDocumentQueryResult>
        {
            PageSize = TjDocument.PageSize,
            CurrentPage = TjDocument.CurrentPage,
            TotalPages = TjDocument.TotalPages,
            TotalCount = TjDocument.TotalCount,
            Result = TjDocument.Select(_mapper.Map<TJ_DOCUMENT_DET_BORD, GetAllTjDocumentQueryResult>).ToList()

        };
        return OperationResult<PageInfo<GetAllTjDocumentQueryResult>>.SuccessResult(result);
    }
}