﻿using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;
namespace CleanArc.Application.Features.TListVal.Commands;

public record AddTListValCommand(Domain.Entities.TR_LIST_VAL listVal) : IRequest<OperationResult<bool>>;

