



using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.Entities
{
    [Keyless]
    public class usp_FRAIS_PAIEMENT_T
    {
        public int ref_ctr { get; set; }
        public Nullable<decimal> FraisPaiT { get; set; }
    }
}

