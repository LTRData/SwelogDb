using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TopitemParameter
{
    public string TopitemNumber { get; set; } = null!;

    public string TopitemParameterCode { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
