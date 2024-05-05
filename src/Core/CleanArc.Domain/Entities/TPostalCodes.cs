

using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities
{
    public class TR_CP : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CodeGouvernorat { get; set; }
        public string CodeRegion { get; set; }
        public string Cp { get; set; }
        public string Gouvernorat { get; set; }
        public string Region { get; set; }
        public string Ville { get; set; }
    }
}