using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVals.Commands.UpdateTListValCommand;

public class UpdateTListValCommandHandler: IRequestHandler<UpdateTListValCommand, OperationResult<Unit>>
{
    private readonly ITListValRepository _tListValRepository;
    private readonly IMapper _mapper;

    public UpdateTListValCommandHandler(ITListValRepository tListValRepository, IMapper mapper)
    {
        _tListValRepository = tListValRepository ?? throw new ArgumentNullException(nameof(tListValRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async ValueTask<OperationResult<Unit>> Handle(UpdateTListValCommand request, CancellationToken cancellationToken)
    {
        var existingListVal = await _tListValRepository.GetTListValById(request.Id);

        if (existingListVal == null)
        {
            return OperationResult<Unit>.FailureResult($"ListVals with id {request.Id} not found.");
        }

        var updatedListVal = _mapper.Map(request, existingListVal);

        try
        {
            await _tListValRepository.UpdateTListValAsync(existingListVal.Id, existingListVal);

            return OperationResult<Unit>.SuccessResult(Unit.Value);
        }
        catch (Exception ex)
        {
            return OperationResult<Unit>.FailureResult($"Error updating ListVals: {ex.Message}");
        }
    }



}