using AutoMapper;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Profiles;

public interface ICreateMapper<TSource>
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
        }
    }
    void Map(Profile profile)
    {
        profile.CreateMap(typeof(TSource), GetType()).ReverseMap();
    }
}

public class UpdateTListValProfile : Profile
{
    
}