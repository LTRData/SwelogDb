using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActionListHdr
{
    public string ActionListId { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ActionListDtl> ActionListDtls { get; } = new List<ActionListDtl>();

    public virtual ICollection<ChangeOrderDtl> ChangeOrderDtls { get; } = new List<ChangeOrderDtl>();

    public virtual ICollection<ChangeOrderHdr> ChangeOrderHdrs { get; } = new List<ChangeOrderHdr>();
}
