using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AtpResource
{
    public string UserId { get; set; } = null!;

    public string ResourceNo { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
