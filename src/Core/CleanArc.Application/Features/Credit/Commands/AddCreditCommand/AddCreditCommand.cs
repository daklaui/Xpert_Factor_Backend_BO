using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Credit.Commands;

public record AddCreditCommand(T_MVT_CREDIT MvtCredit) : IRequest<OperationResult<bool>>;
