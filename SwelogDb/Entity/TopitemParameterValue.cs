using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TopitemParameterValue
{
    public string TopitemNumber { get; set; } = null!;

    public string TopitemParameterCode { get; set; } = null!;

    public string TopitemParameterValueCode { get; set; } = null!;

    public int? SerialNo { get; set; }

    public string? AuditStamp { get; set; }
}
