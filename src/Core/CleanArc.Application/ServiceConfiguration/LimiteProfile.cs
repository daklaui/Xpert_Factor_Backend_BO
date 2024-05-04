using CleanArc.Application.Features.Limite.Commands.ValidateLimiteCommand;
using AutoMapper;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.ServiceConfiguration;

public class LimiteProfile :Profile
{
    public LimiteProfile()
    {
        CreateMap<ValidateLimiteCommand, T_DEM_LIMITE>();
    }
}