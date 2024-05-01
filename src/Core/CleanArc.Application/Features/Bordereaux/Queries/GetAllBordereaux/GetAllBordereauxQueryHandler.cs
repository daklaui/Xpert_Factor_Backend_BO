using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;
using static System.Linq.AsyncEnumerable;

namespace CleanArc.Application.Features.Bordereaux.Queries.GetAllBordereaux;

internal class GetAllBordereauxQueryHandler : IRequestHandler<GetAllBordereauxQuery, OperationResult<PageInfo<GetAllBordereauxQueryResult>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllBordereauxQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<GetAllBordereauxQueryResult>>> Handle(GetAllBordereauxQuery request, CancellationToken cancellationToken)
    {
        var TBordereau = await _unitOfWork.BordereauxRepository.GetAllBordereauxAsync(request.paginationParams);
        var result = new PageInfo<GetAllBordereauxQueryResult>
        {
            PageSize = TBordereau.PageSize,
            CurrentPage = TBordereau.CurrentPage,
            TotalPages = TBordereau.TotalPages,
            TotalCount = TBordereau.TotalCount,
            Result = TBordereau.Select(_mapper.Map<T_BORDEREAU, GetAllBordereauxQueryResult>).ToList()

        };
        return OperationResult<PageInfo<GetAllBordereauxQueryResult>>.SuccessResult(result);
    }
}