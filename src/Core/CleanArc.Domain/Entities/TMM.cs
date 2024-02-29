using CleanArc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Entities
{
    public class TMM :BaseEntity,IEntity
    {
        public Nullable<System.DateTime> StartDateTMM { get; set; }
        public Nullable<System.DateTime> EndDateTMM { get; set; }
        public string RateTMM { get; set; }
    }
}
