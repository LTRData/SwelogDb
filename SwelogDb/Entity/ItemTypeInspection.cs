using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemTypeInspection
{
    public string ItemType2 { get; set; } = null!;

    public int InspectionHdrId { get; set; }

    public string? AuditStamp { get; set; }
}
