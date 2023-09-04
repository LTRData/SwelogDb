using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InspectionOperTool
{
    public string OperationList { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string ToolNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual InspectionOperDtl Operation { get; set; } = null!;

    public virtual ToolHeader ToolNumberNavigation { get; set; } = null!;
}
