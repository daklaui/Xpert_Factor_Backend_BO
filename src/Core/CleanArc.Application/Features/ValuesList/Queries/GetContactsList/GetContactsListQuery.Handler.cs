using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Queries.GetContactsList

{ 
    internal class GetContactsListQueryHandler : IRequestHandler<GetContactsListQuery,OperationResult<PageInfo<GetContactsListQueryResult>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetContactsListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async ValueTask<OperationResult<PageInfo<GetContactsListQueryResult>>> Handle(GetContactsListQuery request, CancellationToken cancellationToken)
        {
            var list = await _unitOfWork.ValuesListRepository.GetContactsList(request.paginationParams);
 
            var result = new PageInfo<GetContactsListQueryResult>
            {
                PageSize = list.PageSize,
                CurrentPage = list.CurrentPage,
                TotalPages = list.TotalPages,
                TotalCount = list.TotalCount,
                Result = list.Select(_mapper.Map<TR_LIST_VAL, GetContactsListQueryResult>).ToList()

            };
            return OperationResult<PageInfo<GetContactsListQueryResult>>.SuccessResult(result);
        }
    }
}