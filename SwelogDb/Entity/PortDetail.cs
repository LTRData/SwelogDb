using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PortDetail
{
    public decimal PortNo { get; set; }

    public string? PortDesc { get; set; }

    public string? AuditStamp { get; set; }
}
