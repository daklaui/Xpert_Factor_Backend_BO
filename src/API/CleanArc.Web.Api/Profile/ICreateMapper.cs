using CleanArc.Application.Features.Limite.Commands.ValidateLimiteCommand;
using CleanArc.Domain.Entities;

namespace CleanArc.Web.Api.Profile;

public interface ICreateMapper<TSource>
{
    void Map(AutoMapper.Profile profile)
    {
        profile.CreateMap(typeof(TSource), GetType()).ReverseMap();
        profile.CreateMap<ValidateLimiteCommand, T_DEM_LIMITE>();

    }
}