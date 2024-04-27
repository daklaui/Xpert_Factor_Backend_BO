using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Limite.Queries.GetListOfDemLimit;

 internal class GetListOfDemLimitQuery_Handler :IRequestHandler<GetListOfDemLimitQuery,OperationResult<PageInfo<GetListOfDemLimitQueryResult>>>
{
 private readonly IUnitOfWork _unitOfWork;
 private readonly IMapper _mapper;

 public GetListOfDemLimitQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
 {
  _unitOfWork = unitOfWork;
  _mapper = mapper;
 }


 public  async ValueTask<OperationResult<PageInfo<GetListOfDemLimitQueryResult>>> Handle(GetListOfDemLimitQuery request, CancellationToken cancellationToken)
 {
  var limite = await _unitOfWork.LimiteRepository.getAllLDemLimites(request.paginationParams);
  var result = new PageInfo<GetListOfDemLimitQueryResult>
  {
   PageSize = limite.PageSize,
   CurrentPage = limite.CurrentPage,
   TotalPages = limite.TotalPages,
   TotalCount = limite.TotalCount,
   Result = limite.Select(_mapper.Map<T_DEM_LIMITE, GetListOfDemLimitQueryResult>).ToList()

  };
  return OperationResult<PageInfo<GetListOfDemLimitQueryResult>>.SuccessResult(result);
 }
}