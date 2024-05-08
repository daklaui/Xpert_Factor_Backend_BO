using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contact.Command;

internal class AddContactCommandHandler : IRequestHandler<AddContactCommand, OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddContactCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public async ValueTask<OperationResult<bool>> Handle(AddContactCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.contactRepository.AddContactAsync(request.contact);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}