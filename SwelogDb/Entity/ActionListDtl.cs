using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActionListDtl
{
    public string ActionListId { get; set; } = null!;

    public int ActionSerial { get; set; }

    public string? Description { get; set; }

    public string? ResponsibleId { get; set; }

    public DateTime? EffectiveFrom { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ActionDocument> ActionDocuments { get; } = new List<ActionDocument>();

    public virtual ActionListHdr ActionList { get; set; } = null!;
}
