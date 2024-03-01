using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;
using System;
using System.Threading;
using System.Threading.Tasks;
using CleanArc.Application.Features.TPostalCodes.Commands;

namespace CleanArc.Application.Features.TPostalCodes.Commands
{
    public class UpdateTPostalCodesCommandHandler : IRequestHandler<UpdateTPostalCodesCommand, OperationResult<Unit>>
    {
        private readonly ITPostalCodesRepository _tPostalCodesRepository;
        private readonly IMapper _mapper;

        public UpdateTPostalCodesCommandHandler(ITPostalCodesRepository tPostalCodesRepository, IMapper mapper)
        {
            _tPostalCodesRepository = tPostalCodesRepository ?? throw new ArgumentNullException(nameof(tPostalCodesRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async ValueTask<OperationResult<Unit>> Handle(UpdateTPostalCodesCommand request, CancellationToken cancellationToken)
        {
            var existingTPostalCodes = await _tPostalCodesRepository.GetTPostalCodesById(request.Id);

            if (existingTPostalCodes == null)
            {
                return OperationResult<Unit>.FailureResult($"TPostalCodes with id {request.Id} not found.");
            }

            _mapper.Map(request, existingTPostalCodes);

            try
            {
                await _tPostalCodesRepository.UpdateTPostalCodesAsync(existingTPostalCodes.Id, existingTPostalCodes);

                return OperationResult<Unit>.SuccessResult(Unit.Value);
            }
            catch (Exception ex)
            {
                return OperationResult<Unit>.FailureResult($"Error updating TPostalCodes: {ex.Message}");
            }
        }
    }
}
