using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.FactoringCommission.Commands.UpdateFactoringCommissionCommand
{
    public class UpdateFactoringCommissionCommandHandler : IRequestHandler<UpdateFactoringCommissionCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateFactoringCommissionCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async ValueTask<OperationResult<bool>> Handle(UpdateFactoringCommissionCommand request, CancellationToken cancellationToken)
        {
            var existingCommission = await _unitOfWork.FactoringCommissionRepository.GetFactoringCommissionById(request.FactoringCommission.REF_CTR_COMM_FACTORING);

            if (existingCommission == null)
            {
                return OperationResult<bool>.FailureResult($"Factoring commission with id {request.FactoringCommission.REF_CTR_COMM_FACTORING} not found.");
            }

            _mapper.Map(request.FactoringCommission, existingCommission);

            try
            {
                await _unitOfWork.FactoringCommissionRepository.UpdateFactoringCommissionAsync(existingCommission.REF_CTR_COMM_FACTORING, request.FactoringCommission);

                return OperationResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.FailureResult($"Error updating factoring commission: {ex.Message}");
            }
        }
    }
}
