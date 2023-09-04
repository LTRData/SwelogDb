using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AccountGroup
{
    public string AccountGroupNo { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public string? Description { get; set; }
}
