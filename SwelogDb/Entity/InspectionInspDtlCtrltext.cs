using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InspectionInspDtlCtrltext
{
    public string OperationList { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string ControlTextCode { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
