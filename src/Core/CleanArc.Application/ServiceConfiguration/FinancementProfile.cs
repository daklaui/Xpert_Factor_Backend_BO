using AutoMapper;
using CleanArc.Application.Features.Financement.Commands.RejectFinancementCommand;
using CleanArc.Application.Features.Financement.Commands.UpdateFinancementCommand;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.ServiceConfiguration;

public class FinancementProfile:Profile
{
    public FinancementProfile()
    {
        CreateMap<ValidateFinanceCommand, T_FINANCEMENT>();
        CreateMap<RejectFinanceCommand, T_FINANCEMENT>();

    }
}