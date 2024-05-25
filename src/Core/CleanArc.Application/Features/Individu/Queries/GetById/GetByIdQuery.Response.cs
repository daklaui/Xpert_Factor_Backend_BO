using CleanArc.Application.Profiles;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using AutoMapper;

namespace CleanArc.Application.Features.Individu.Queries.GetByIdQuery
{
    public record GetByIdQueryResult : ICreateMapper<IndividualDTO>
    {
        public T_INDIVIDU Individu { get; set; }
        public List<TR_RIB> TrRibs { get; set; }
        public List<T_CONTACT> Contacts { get; set; }
        public TS_USERS_WEB TsUsers { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<IndividualDTO, GetByIdQueryResult>();
            profile.CreateMap<T_INDIVIDU, GetByIdQueryResult>();
        }
    }
}