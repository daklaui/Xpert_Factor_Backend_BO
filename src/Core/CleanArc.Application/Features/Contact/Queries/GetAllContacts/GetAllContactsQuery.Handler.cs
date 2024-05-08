using AutoMapper;
using CleanArc.Application.Common;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Contact.Queries.GetAllContacts;

internal class GetAllContactsQuery_Handler:IRequestHandler<GetAllContactQuery,OperationResult<PageInfo<GetAllContactsQuery_Response>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllContactsQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<PageInfo<GetAllContactsQuery_Response>>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
    {
        var ListContact = await _unitOfWork.contactRepository.GetAllContactsAsync(request.PaginationParams);
 
        var result = new PageInfo<GetAllContactsQuery_Response>
        {
            PageSize =ListContact.PageSize,
            CurrentPage =ListContact.CurrentPage,
            TotalPages = ListContact.TotalPages,
            TotalCount = ListContact.TotalCount,
            Result = ListContact.Select(_mapper.Map<T_CONTACT, GetAllContactsQuery_Response>).ToList()

        };
        return OperationResult<PageInfo<GetAllContactsQuery_Response>>.SuccessResult(result);
    }
}