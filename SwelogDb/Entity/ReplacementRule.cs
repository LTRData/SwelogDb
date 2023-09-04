using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReplacementRule
{
    public string ItemNumber { get; set; } = null!;

    public string? NewItemNumber { get; set; }

    public string? ProductGroup { get; set; }

    public string? AuditStamp { get; set; }
}
