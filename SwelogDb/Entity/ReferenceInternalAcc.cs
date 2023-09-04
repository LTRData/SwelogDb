using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReferenceInternalAcc
{
    public string RefTranId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
