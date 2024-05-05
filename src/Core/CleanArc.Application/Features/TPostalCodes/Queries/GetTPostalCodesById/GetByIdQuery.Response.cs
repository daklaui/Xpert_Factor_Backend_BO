using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;
using System;

namespace CleanArc.Application.Features.TPostalCodes.Queries.GetTPostalCodesById
{
    public record GetByIdQueryResult : ICreateMapper<Domain.Entities.TR_CP>
    {
        public string CodeGouvernorat { get; set; }
        public string CodeRegion { get; set; }
        public string D_Cp { get; set; }
        public string Gouvernorat { get; set; }
        public string Region { get; set; }
        public string Ville { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
