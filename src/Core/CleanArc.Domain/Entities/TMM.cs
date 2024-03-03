using CleanArc.Domain.Common;


namespace CleanArc.Domain.Entities
{
    public class TRTMM :BaseEntity,IEntity
    {
        public Nullable<System.DateTime> StartDateTMM { get; set; }
        public Nullable<System.DateTime> EndDateTMM { get; set; }
        public string RateTMM { get; set; }
    }
}
