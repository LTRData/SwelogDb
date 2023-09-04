using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletCode
{
    public string PalletCode1 { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }
}
