using AutoMapper;
using CleanArc.Application.Features.TJobs.Commands.UpdateTJobs;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.ServiceConfiguration
{
    public class TJobsProfile : Profile
    {
        public TJobsProfile()
        {
            CreateMap<UpdateTJobsCommand, TJobs>();
        }
    }
}
