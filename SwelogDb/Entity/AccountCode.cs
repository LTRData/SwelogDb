using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AccountCode
{
    public string AccountType { get; set; } = null!;

    public string AccountCode1 { get; set; } = null!;

    public string? AccountDescription { get; set; }

    public int? AccountDescriptionTxtid { get; set; }

    public string? AuditStamp { get; set; }
}
