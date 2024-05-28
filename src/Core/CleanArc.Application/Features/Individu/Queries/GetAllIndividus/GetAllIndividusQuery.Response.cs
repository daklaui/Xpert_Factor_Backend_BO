﻿using CleanArc.Application.Profiles;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;


namespace CleanArc.Application.Features.Individu.Queries.GetAllIndividus
{
    public record GetAllIndividusQueryResult : ICreateMapper<IndividualDTO>
    {
        public T_INDIVIDU Individu { get; set; }
        public List<TR_RIB> TrRibs { get; set; }
        public List<T_CONTACT> Contacts { get; set; }
        public TS_USERS_WEB TsUsers { get; set; }
    }
}