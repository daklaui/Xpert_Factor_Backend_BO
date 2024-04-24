using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;
using System.Collections.Generic;

namespace CleanArc.Application.Features.ListValue.Queries.GetById
{
    public record GetByIdListValueQueryResult : ICreateMapper<TR_LIST_VAL>
    {
        public int ID_LIST_VAL { get; set; }

        public string ABR_LIST_VAL { get; set; }

        public string TYP_LIST_VAL { get; set; }

        public short? ORD_LIST_VAL { get; set; }

        public string LIB_LIST_VAL { get; set; }

        public string COM_LIST_VAL { get; set; }

        public int? NB_JOUR_LIST_VAL { get; set; }

        public string TYPE_RECOUVREMENT { get; set; }

        // Ajoutez d'autres propriétés si nécessaire

        // Relations avec d'autres entités, si elles existent
        public virtual ICollection<TJ_GRP_PERMISSION> TJ_GRP_PERMISSIONs { get; } = new List<TJ_GRP_PERMISSION>();
    }
}
