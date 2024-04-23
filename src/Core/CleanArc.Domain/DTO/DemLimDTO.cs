using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.DTO
{
    public class DemLimListingDTO
    {
        public int REF_CTR_DEM_LIM { get; set; }
        public int REF_ACH_LIM { get; set; }
        public bool ACTIF_DEM_LIMI { get; set; }
        public DateTime DAT_DEM_LIM { get; set; }
        public int REF_DEM_LIM { get; set; }
        public string DECISION_LIM { get; set; }
        public int DELAIS_DEM_LIM { get; set; }
        public string DEVISE { get; set; }
        public string MODE_PAY_DEM_LIM { get; set; }
        public decimal MONT_DEM_LIM { get; set; }
        public string SORT_DEM_LIM { get; set; }
        public string TYP_DEM_LIM { get; set; }
        public int DELAIS_ACC { get; set; }
        public decimal MONT_ACC { get; set; }
        public string MODE_PAY_ACC { get; set; }
        public string NOM_IND { get; set; }
    }
}
