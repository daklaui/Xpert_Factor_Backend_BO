using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArc.Application.Features.Individu.Commands.UpdateIndividuCommand
{
    public class UpdateIndividuCommandHandler : IRequestHandler<UpdateIndividuCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateIndividuCommandHandler(IMapper mapper,IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async ValueTask<OperationResult<bool>> Handle(UpdateIndividuCommand request, CancellationToken cancellationToken)
        {
            var existingIndividu = await _unitOfWork.IndividualRepository.GetIndividuById(request.Individu.REF_IND);

            if (existingIndividu == null)
            {
                return OperationResult<bool>.FailureResult($"Individu with id {request.Individu.REF_IND} not found.");
            }

            _mapper.Map(request.Individu, existingIndividu);

            try
            {
                await _unitOfWork.IndividualRepository.UpdateIndividuAsync(existingIndividu.REF_IND, request.Individu);
                

                return OperationResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.FailureResult($"Error updating Individu: {ex.Message}");
            }
        }
    }
}
