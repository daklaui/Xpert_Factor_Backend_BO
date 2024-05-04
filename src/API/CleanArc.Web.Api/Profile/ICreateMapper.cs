
using CleanArc.Application.Features.Financement.Commands.RejectFinancementCommand;
using CleanArc.Domain.Entities;
using ValidateFinanceCommand = CleanArc.Application.Features.Financement.Commands.UpdateFinancementCommand.ValidateFinanceCommand;

namespace CleanArc.Web.Api.Profile;

public interface ICreateMapper<TSource>
{
    void Map(AutoMapper.Profile profile)
    {
        profile.CreateMap(typeof(TSource), GetType()).ReverseMap();
        profile.CreateMap<ValidateFinanceCommand, T_FINANCEMENT>();
        profile.CreateMap<RejectFinanceCommand, T_FINANCEMENT>();

    }
}