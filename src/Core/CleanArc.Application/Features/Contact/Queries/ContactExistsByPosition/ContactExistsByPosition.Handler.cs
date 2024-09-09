using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;


namespace CleanArc.Application.Features.Contact.Queries.ContactExistsTelQuery;

internal class ContactExistsPositionQuery_Handler
    : IRequestHandler<ContactExistsPositionQuery, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public ContactExistsPositionQuery_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask <OperationResult<bool>> Handle(ContactExistsPositionQuery request, CancellationToken cancellationToken)
    {
        bool exists = await _unitOfWork.contactRepository.ContactExistsByPositionAsync(request.refIndiv, request.position);

        if (exists)
        {
            return OperationResult<bool>.SuccessResult(true);
        }
        else
        {
            return OperationResult<bool>.FailureResult("Contact does not exist or position email does not match.");
        }
    }
}
