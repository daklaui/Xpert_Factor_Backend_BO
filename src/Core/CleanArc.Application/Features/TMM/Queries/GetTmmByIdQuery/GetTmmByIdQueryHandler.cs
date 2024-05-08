using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.Individu.Queries.GetByIdQuery;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TMM.Queries.GetTmmByIdQuerie;


internal class GetTmmByIdQueryHandler :IRequestHandler<GetTmmByIdQuery,OperationResult<GetTmmByIdQueryResult>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetTmmByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async ValueTask<OperationResult<GetTmmByIdQueryResult>> Handle(GetTmmByIdQuery request, CancellationToken cancellationToken)
    {
        var tmm= await _unitOfWork.TmmRepository.GetTrTmmById(request.idTmm);

        var result =   _mapper.Map<TR_TMM, GetTmmByIdQueryResult>(tmm);

        return OperationResult<GetTmmByIdQueryResult>.SuccessResult(result);
    }
}