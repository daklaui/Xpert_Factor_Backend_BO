using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TR_CP.Commands.UpdateTR_CPCommand
{
    public class UpdateTR_CPCommandHandler : IRequestHandler<UpdateTR_CPCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateTR_CPCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        
        public async ValueTask<OperationResult<bool>> Handle(UpdateTR_CPCommand request, CancellationToken cancellationToken)
        {
            var existingTR_CP = await _unitOfWork.TR_CPRepository.GetTR_CPById(request.TR_CP.ID_CP);

            if (existingTR_CP == null)
            {
                return OperationResult<bool>.FailureResult($"TR_CP with id {request.TR_CP.ID_CP} not found.");
            }

            _mapper.Map(request.TR_CP, existingTR_CP);

            try
            {
                await _unitOfWork.TR_CPRepository.UpdateTR_CPAsync(existingTR_CP.ID_CP, request.TR_CP);

                return OperationResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.FailureResult($"Error updating TR_CP: {ex.Message}");
            }
        }

    }
}
