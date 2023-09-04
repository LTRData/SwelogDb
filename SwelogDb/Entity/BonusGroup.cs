using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BonusGroup
{
    public string BonusGroupId { get; set; } = null!;

    public string BonusGroupDescription { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
