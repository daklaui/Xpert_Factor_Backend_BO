using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;


namespace CleanArc.Application.Features.Contact.Queries.ContactExistsTelQuery;

internal class ContactExistsTelQuery_Handler
    : IRequestHandler<ContactExistsTelQuery, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public ContactExistsTelQuery_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask <OperationResult<bool>> Handle(ContactExistsTelQuery request, CancellationToken cancellationToken)
    {
        bool exists = await _unitOfWork.contactRepository.ContactExistsTelAsync(request.RefIndiv, request.PhoneNumber);

        if (exists)
        {
            return OperationResult<bool>.SuccessResult(true);
        }
        else
        {
            return OperationResult<bool>.FailureResult("Contact does not exist or phone number does not match.");
        }
    }
}
