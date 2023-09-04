using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgMfgInspectionDtlCtrltext
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string ControlTextCode { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual MfgMfgInspectionHdr MfgMfgInspectionHdr { get; set; } = null!;
}
