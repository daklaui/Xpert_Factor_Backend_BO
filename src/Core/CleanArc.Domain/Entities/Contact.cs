using CleanArc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Entities
{
    public class TContact : BaseEntity
    {
        public string NomPreContact { get; set; }
        public string PosContact { get; set; }
        public string Tel1Contact { get; set; }
        public string Tel2Contact { get; set; }
        public string Mail1Coontact { get; set; }
        public string Mail2Coontact { get; set; }
        public string FaxContact { get; set; }
        public bool ActifContact { get; set; }
        
        public  ICollection<TIndividu> Individus { get; }= new List<TIndividu>();

    }
}
