using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AtpItem
{
    public string UserId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
