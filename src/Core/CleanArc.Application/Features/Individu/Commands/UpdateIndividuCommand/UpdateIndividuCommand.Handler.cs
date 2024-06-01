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
            var existingIndividu = await _unitOfWork.IndividualRepository.GetIndividuByIdAsync(request.IndividualDTO.Individu.REF_IND);

            if (existingIndividu == null)
            {
                return OperationResult<bool>.FailureResult($"Individu with id {request.IndividualDTO.Individu.REF_IND} not found.");
            }

            await _unitOfWork.IndividualRepository.UpdateIndividuAsync(existingIndividu.Individu.REF_IND, request.IndividualDTO);
            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }

    }
}
