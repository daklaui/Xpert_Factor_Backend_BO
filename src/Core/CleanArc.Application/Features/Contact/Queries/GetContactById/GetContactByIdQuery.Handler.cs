using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Contact.Queries.GetContactById;

internal class GetContactByIdQuery_Handler:IRequestHandler<GetContactByIdQuery,OperationResult<GetContactByIdQuery_Response>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetContactByIdQuery_Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<OperationResult<GetContactByIdQuery_Response>> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
    {
        var Contact = await _unitOfWork.contactRepository.GetContactById(request.id);

        var result =   _mapper.Map<T_CONTACT, GetContactByIdQuery_Response>(Contact);

        return OperationResult<GetContactByIdQuery_Response>.SuccessResult(result);
    }
}