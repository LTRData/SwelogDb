using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PackagingInstruction
{
    public string PackagingInstructionCode { get; set; } = null!;

    public string? PackagingDesc { get; set; }

    public int? PackagingDescTxtid { get; set; }

    public string? PackagingDescFlag { get; set; }

    public string? AuditStamp { get; set; }
}
