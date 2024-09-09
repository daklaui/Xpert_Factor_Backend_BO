using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;


namespace CleanArc.Application.Features.Contact.Queries.ContactExistsTelQuery;

internal class ContactExistsEmailQuery_Handler
    : IRequestHandler<ContactExistsEmailQuery, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public ContactExistsEmailQuery_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask <OperationResult<bool>> Handle(ContactExistsEmailQuery request, CancellationToken cancellationToken)
    {
        bool exists = await _unitOfWork.contactRepository.ContactExistsEmailAsync(request.RefIndiv, request.email);

        if (exists)
        {
            return OperationResult<bool>.SuccessResult(true);
        }
        else
        {
            return OperationResult<bool>.FailureResult("Contact does not exist or phone email does not match.");
        }
    }
}
