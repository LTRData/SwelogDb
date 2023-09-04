using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemRelationship
{
    public string ItemNumber { get; set; } = null!;

    public string ChildItemNumber { get; set; } = null!;

    public string ItemRelationType { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual Item ChildItemNumberNavigation { get; set; } = null!;

    public virtual Item ItemNumberNavigation { get; set; } = null!;
}
