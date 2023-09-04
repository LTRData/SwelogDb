using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Pm
{
    public string PmsCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }
}
