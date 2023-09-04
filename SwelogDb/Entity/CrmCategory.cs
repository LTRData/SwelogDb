using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmCategory
{
    public string CategoryCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
