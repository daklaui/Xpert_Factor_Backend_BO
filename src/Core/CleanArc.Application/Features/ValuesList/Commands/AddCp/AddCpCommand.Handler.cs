using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Commands.AddCp;


internal class AddCpCommandHandler : IRequestHandler<AddCpCommand,OperationResult<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddCpCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<OperationResult<bool>> Handle(AddCpCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.CpRepository.AddCpAsync(request.cp);

        await _unitOfWork.CommitAsync();

        return OperationResult<bool>.SuccessResult(true);
    }
}
