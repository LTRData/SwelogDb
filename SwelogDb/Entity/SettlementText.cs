using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SettlementText
{
    public int SlNo { get; set; }

    public string? Text { get; set; }

    public string? AccountNo { get; set; }

    public string? AuditStamp { get; set; }
}
