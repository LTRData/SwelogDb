using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class FaRgControlCode
{
    public string ControlCode { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
