using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Web.Api.Profile;

public class BordereauxProfile : AutoMapper.Profile
{
    public BordereauxProfile()
    {
        CreateMap<T_BORDEREAU, BordereauDTO>();
        CreateMap<T_DET_BORD, T_det_bord_DTO>();
        CreateMap<PksBordereauxDto, T_BORDEREAU>();
        CreateMap<T_det_bord_DTO, T_DET_BORD>()
            .ReverseMap();
    }
}
