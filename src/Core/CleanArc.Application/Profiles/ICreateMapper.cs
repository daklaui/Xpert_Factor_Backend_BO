using AutoMapper;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Profiles;

public interface ICreateMapper<TSource>
{
    void Map(Profile profile)
    {
        profile.CreateMap(typeof(TSource), GetType()).ReverseMap();
    }
}
