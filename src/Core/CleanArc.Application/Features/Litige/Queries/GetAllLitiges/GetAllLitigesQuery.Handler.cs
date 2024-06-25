using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;


namespace CleanArc.Application.Features.Litige.Queries.GetAllLitiges;

 internal class GetAllLitigesQuery_Handler : IRequestHandler<GetAllLitigesQuery, OperationResult<PageInfo<GetAllLitigesQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllLitigesQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async ValueTask<OperationResult<PageInfo<GetAllLitigesQuery_Response>>> Handle(GetAllLitigesQuery request, CancellationToken cancellationToken)
    {
        var litiges = await _unitOfWork.LitigesRepository.GetAllLitigesAsync(request.PaginationParams);
      
                  var result = new PageInfo<GetAllLitigesQuery_Response>
                  {
                      PageSize = litiges.PageSize,
                      CurrentPage = litiges.CurrentPage,
                      TotalPages =litiges.TotalPages,
                      TotalCount = litiges.TotalCount,
                      Result = litiges.Select(_mapper.Map<T_LITIGE, GetAllLitigesQuery_Response>).ToList()
      
                  };
                  return OperationResult<PageInfo<GetAllLitigesQuery_Response>>.SuccessResult(result);
    }
}

