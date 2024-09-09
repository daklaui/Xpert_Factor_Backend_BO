using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contact.Command.UpdateContact;

public class AddContactCommand_Handler:IRequestHandler<UpdateContactCommand,OperationResult<bool>>
{
    private IUnitOfWork _unitOfWork;

    public AddContactCommand_Handler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
    {
        var existingContact = await _unitOfWork.contactRepository.GetContactById(request.Contact.ID_CONTACT);
        await _unitOfWork.contactRepository.UpdateContactAsync(existingContact.ID_CONTACT,request.Contact);
        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}