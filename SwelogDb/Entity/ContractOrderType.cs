using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ContractOrderType
{
    public string ContractOrderType1 { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuditStamp { get; set; }
}
