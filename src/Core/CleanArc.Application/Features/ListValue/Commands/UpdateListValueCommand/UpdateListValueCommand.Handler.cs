using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArc.Application.Features.ListValue.Commands.UpdateListValueCommand
{
    public class UpdateListValueCommandHandler : IRequestHandler<UpdateListValueCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateListValueCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async ValueTask<OperationResult<bool>> Handle(UpdateListValueCommand request, CancellationToken cancellationToken)
        {
            var existingListValue = await _unitOfWork.ListValueRepository.GetListValueById(request.ListValue.ID_LIST_VAL);

            if (existingListValue == null)
            {
                return OperationResult<bool>.FailureResult($"ListValue with id {request.ListValue.ID_LIST_VAL} not found.");
            }

            _mapper.Map(request.ListValue, existingListValue);

            try
            {
                await _unitOfWork.ListValueRepository.UpdateListValueAsync(existingListValue.ID_LIST_VAL, request.ListValue);

                return OperationResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.FailureResult($"Error updating ListValue: {ex.Message}");
            }
        }
    }
}
