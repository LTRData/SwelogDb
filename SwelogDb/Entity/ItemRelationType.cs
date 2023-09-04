using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemRelationType
{
    public string ItemRelationType1 { get; set; } = null!;

    public string? RelationDesc { get; set; }

    public int? RelationDescTxtid { get; set; }

    public string? RelationDescFlag { get; set; }

    public string? AuditStamp { get; set; }
}
