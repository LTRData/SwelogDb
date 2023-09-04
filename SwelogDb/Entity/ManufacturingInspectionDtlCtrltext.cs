using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ManufacturingInspectionDtlCtrltext
{
    public string OperationListId { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string ControlTextCode { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
