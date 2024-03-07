using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;
namespace CleanArc.Application.Features.ListVals.Commands;

public record AddTListValCommand(TRListVals TRListVals) : IRequest<OperationResult<bool>>;

