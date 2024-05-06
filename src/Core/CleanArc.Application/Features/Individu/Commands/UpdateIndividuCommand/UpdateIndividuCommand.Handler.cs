using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Commands.UpdateIndividuCommand
{
    public class UpdateIndividuCommandHandler : IRequestHandler<UpdateIndividuCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateIndividuCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async ValueTask<OperationResult<bool>> Handle(UpdateIndividuCommand request, CancellationToken cancellationToken)
        {
            var existingIndividu = await _unitOfWork.IndividualRepository.GetIndividuById(request.Individu.REF_IND);

            if (existingIndividu == null)
            {
                return OperationResult<bool>.FailureResult($"Individu with id {request.Individu.REF_IND} not found.");
            }
            await _unitOfWork.IndividualRepository.UpdateIndividuAsync(existingIndividu.REF_IND, request.Individu);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }

        }
}
