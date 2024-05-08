using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.PostalCode.Commands.AddPostalCodeCommand;

public record AddPostalCodeCommand(TR_CP TrCp) : IRequest<OperationResult<bool>>;
