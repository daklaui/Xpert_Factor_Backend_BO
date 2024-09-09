using CleanArc.Domain.Entities;
using System.Collections.Generic;

namespace CleanArc.Domain.DTO
{
    public class IndividualDTO
    {
        public T_INDIVIDU Individu { get; set; }
        public List<TR_RIB> TrRibs { get; set; }
       public List<T_CONTACT> Contacts { get; set; }
        public TS_USERS_WEB TsUsers { get; set; }
    }
}