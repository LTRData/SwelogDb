using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustFreeCode
{
    public string CustFreeCode1 { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
