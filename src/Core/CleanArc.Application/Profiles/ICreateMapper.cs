using AutoMapper;
using CleanArc.Application.Features.ListVals.Commands.UpdateTListValCommand;
using CleanArc.Application.Features.TListVal.Queries.GetAllTListVals;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Profiles;

public interface ICreateMapper<TSource>
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TRListVals, GetAllTListValsQueryResult>();
        }
    }
    void Map(Profile profile)
    {
        profile.CreateMap(typeof(TSource), GetType()).ReverseMap();
    }
}
public class UpdateTListValProfile : Profile
{
    public UpdateTListValProfile()
    {
        CreateMap<UpdateTListValCommand, TRListVals>();
    }
}