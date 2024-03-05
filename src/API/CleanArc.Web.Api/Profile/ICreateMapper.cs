using CleanArc.Application.Features.TPostalCodes.Commands;
using CleanArc.Domain.Entities;

namespace CleanArc.Web.Api.Profile;

public interface ICreateMapper<TSource>
{
    
    void Map(AutoMapper.Profile profile)
    {
        profile.CreateMap(typeof(TSource), GetType()).ReverseMap();
        profile.CreateMap<UpdateTPostalCodesCommand, TPostalCodes>();
    }
    
    
}