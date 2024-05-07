
using CleanArc.Application.Features.Financement.Commands.RejectFinancementCommand;
using CleanArc.Domain.Entities;
using ValidateFinanceCommand = CleanArc.Application.Features.Financement.Commands.UpdateFinancementCommand.ValidateFinanceCommand;

using CleanArc.Domain.Entities;

using CleanArc.Application.Features.Limite.Commands.ValidateLimiteCommand;
using CleanArc.Domain.Entities;

namespace CleanArc.Web.Api.Profile;

public interface ICreateMapper<TSource>
{
    
    void Map(AutoMapper.Profile profile)
    {
        profile.CreateMap(typeof(TSource), GetType()).ReverseMap();
        
    }
    
    
}