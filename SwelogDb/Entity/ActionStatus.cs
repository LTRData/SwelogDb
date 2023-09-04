using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActionStatus
{
    public string StatusCode { get; set; } = null!;

    public string? StatusDescription { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<EcoActionListForHdr> EcoActionListForHdrs { get; } = new List<EcoActionListForHdr>();

    public virtual ICollection<EcoActionList> EcoActionLists { get; } = new List<EcoActionList>();
}
