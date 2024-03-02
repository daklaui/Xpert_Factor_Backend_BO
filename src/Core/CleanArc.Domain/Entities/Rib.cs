using CleanArc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Entities
{
    public class TRib : BaseEntity
    {
        public string RibRib { get; set; } 
        public bool ActifRib { get; set; }
        public TIndividu individu { get; set; }
    }
}
