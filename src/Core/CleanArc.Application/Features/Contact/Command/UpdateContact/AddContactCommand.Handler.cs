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
        await _unitOfWork.contactRepository.UpdateContactAsync(request.id, request.Contact);
        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}