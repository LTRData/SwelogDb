using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvAttestRule
{
    public string Purchaser { get; set; } = null!;

    public string Preattest1 { get; set; } = null!;

    public string Preattest2 { get; set; } = null!;

    public string FinalAttest { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
