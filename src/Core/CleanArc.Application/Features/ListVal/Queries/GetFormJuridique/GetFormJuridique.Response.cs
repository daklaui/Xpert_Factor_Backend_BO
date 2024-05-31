using CleanArc.Application.Profiles;

namespace CleanArc.Application.Features.ListVal.Queries.GetFormJuridique
{
    public record GetFormJuridiqueQueryResult : ICreateMapper<Domain.Entities.TR_LIST_VAL>
    {
        public string ABR_LIST_VAL { get; set; }

        public string TYP_LIST_VAL { get; set; }

        public short? ORD_LIST_VAL { get; set; }

        public string LIB_LIST_VAL { get; set; }

        public string COM_LIST_VAL { get; set; }

        public int ID_LIST_VAL { get; set; }

        public int? NB_JOUR_LIST_VAL { get; set; }

        public string TYPE_RECOUVREMENT { get; set; }
    }
}