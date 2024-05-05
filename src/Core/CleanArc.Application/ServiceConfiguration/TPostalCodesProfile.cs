using AutoMapper;
using CleanArc.Application.Features.TJobs.Commands.UpdateTJobs;
using CleanArc.Application.Features.TPostalCodes.Commands;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.ServiceConfiguration
{
    public class TPostalCodesProfile : Profile
    {
        public TPostalCodesProfile()
        {
            CreateMap<UpdateTPostalCodesCommand, TR_CP>();
            
        }
    }
}
