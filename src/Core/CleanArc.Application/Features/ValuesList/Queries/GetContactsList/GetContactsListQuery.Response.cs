using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.ValuesList.Queries.GetContactsList;

public class GetContactsListQueryResult : ICreateMapper<TR_LIST_VAL>
{
    public string ABR_LIST_VAL { get; set; }

    public string TYP_LIST_VAL { get; set; }

    public short? ORD_LIST_VAL { get; set; }

    public string LIB_LIST_VAL { get; set; }

    public string COM_LIST_VAL { get; set; }

    public int ID_LIST_VAL { get; set; }

    public int? NB_JOUR_LIST_VAL { get; set; }

    public string TYPE_RECOUVREMENT { get; set; }

    public virtual ICollection<TJ_GRP_PERMISSION> TJ_GRP_PERMISSIONs { get; } = new List<TJ_GRP_PERMISSION>();

}
