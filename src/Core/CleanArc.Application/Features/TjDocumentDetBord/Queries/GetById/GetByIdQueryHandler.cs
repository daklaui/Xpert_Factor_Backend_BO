using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TjDocumentDetBord.Queries.GetById;

internal class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, OperationResult<GetByIdQueryResult>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async ValueTask<OperationResult<GetByIdQueryResult>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        var TjDocument = await _unitOfWork.TjDocumentDetBordRepository.GetTj_documentById(request.TjDocumentId);

        var result =   _mapper.Map<TJ_DOCUMENT_DET_BORD, GetByIdQueryResult>(TjDocument);

        return OperationResult<GetByIdQueryResult>.SuccessResult(result);
    }
}