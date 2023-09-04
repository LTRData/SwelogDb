using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerAccountCode
{
    public string Code { get; set; } = null!;

    public string? Text { get; set; }

    public int? TextTxtid { get; set; }

    public string? AuditStamp { get; set; }
}
