using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;
namespace CleanArc.Application.Features.FraisDivers.Commands.UpdateFraisDiversCommand
{
    public class UpdateFraisDiversCommandHandler : IRequestHandler<UpdateFraisDiversCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateFraisDiversCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async ValueTask<OperationResult<bool>> Handle(UpdateFraisDiversCommand request, CancellationToken cancellationToken)
        {
            var existingFraisDivers = await _unitOfWork.FraisDiversRepository.GetFraisDiversById(request.FraisDivers.REF_CTR_FRAIS_DIVERS);

            if (existingFraisDivers == null)
            {
                return OperationResult<bool>.FailureResult($"Frais divers with id {request.FraisDivers.REF_CTR_FRAIS_DIVERS} not found.");
            }

            _mapper.Map(request.FraisDivers, existingFraisDivers);

            try
            {
                await _unitOfWork.FraisDiversRepository.UpdateFraisDiversAsync(existingFraisDivers.REF_CTR_FRAIS_DIVERS, request.FraisDivers);
                return OperationResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.FailureResult($"Error updating frais divers: {ex.Message}");
            }
        }
    }
}
