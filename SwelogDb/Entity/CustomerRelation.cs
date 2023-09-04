using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerRelation
{
    public string ChildCustomerId { get; set; } = null!;

    public string ParentCustomerId { get; set; } = null!;

    public string RelationId { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
