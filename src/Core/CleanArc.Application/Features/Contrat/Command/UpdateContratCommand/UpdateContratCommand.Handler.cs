using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Commands.UpdateContratCommand
{
    public class UpdateContratCommandHandler : IRequestHandler<UpdateContratCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateContratCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async ValueTask<OperationResult<bool>> Handle(UpdateContratCommand request, CancellationToken cancellationToken)
        {
            var existingContrat = await _unitOfWork.ContratRepository.GetContratById(request.Contrat.REF_CTR);

            if (existingContrat == null)
            {
                return OperationResult<bool>.FailureResult($"Contrat with id {request.Contrat.REF_CTR} not found.");
            }

            _mapper.Map(request.Contrat, existingContrat);

            try
            {
                await _unitOfWork.ContratRepository.UpdateContratAsync(existingContrat.REF_CTR, request.Contrat);

                return OperationResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.FailureResult($"Error updating Contrat: {ex.Message}");
            }
        }
    }
}
