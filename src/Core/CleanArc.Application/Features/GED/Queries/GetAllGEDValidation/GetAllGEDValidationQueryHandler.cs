using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.GED.Queries.GetAllGEDValidation;

public class GetAllGEDValidationQueryHandler: IRequestHandler<GetAllGEDValidationQuery,OperationResult<PageInfo<GetAllGEDValidationQueryResult>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllGEDValidationQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async ValueTask<OperationResult<PageInfo<GetAllGEDValidationQueryResult>>> Handle(GetAllGEDValidationQuery request, CancellationToken cancellationToken)
    {
        var GEDValidation = await _unitOfWork.GEDRepository.GetAllGEDValidationAsync(request.paginationParams);
 
        var result = new PageInfo<GetAllGEDValidationQueryResult>
        {
            PageSize = GEDValidation.Count,
            CurrentPage = 1,
            TotalPages = 10,
            TotalCount = GEDValidation.Count,
            Result = GEDValidation.Select(_mapper.Map<GEDValidationDTO, GetAllGEDValidationQueryResult>).ToList()

        };
        return OperationResult<PageInfo<GetAllGEDValidationQueryResult>>.SuccessResult(result);
    }
}