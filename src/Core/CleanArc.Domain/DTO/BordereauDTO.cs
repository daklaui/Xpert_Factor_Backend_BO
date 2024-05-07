using CleanArc.Domain.Entities;

namespace CleanArc.Domain.DTO;

public class BordereauDTO
{
    public T_BORDEREAU  Bordereau { get; set; }
    public List<T_det_bord_DTO> DetBords { get; set; }
}