
using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Features.Contact.Queries.GetIsContactBelongsToContract;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

internal class VerifContactExistsQuery_Handler
    : IRequestHandler<VerifContactExistsQuery,OperationResult<VerifContactExistsQuery_Response>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public VerifContactExistsQuery_Handler(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async ValueTask<OperationResult<VerifContactExistsQuery_Response>> Handle(VerifContactExistsQuery request, CancellationToken cancellationToken)
    {
        var Contact = await _unitOfWork.contactRepository.VerifContactExists(request.contactId);

        var result =   _mapper.Map<T_CONTACT, VerifContactExistsQuery_Response>(Contact);

        return OperationResult<VerifContactExistsQuery_Response>.SuccessResult(result);
    }
}