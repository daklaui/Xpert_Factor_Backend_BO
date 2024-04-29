using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TDetBord.Commands.UpdateTDetBordCommand;

public record UpdateTDetBordCommand : IRequest<OperationResult<bool>>
{
   public PksDetBordDto TdetBordToUpdate { get; set; }
  public  T_det_bord_DTO updatedDetBord { get; set; }
}