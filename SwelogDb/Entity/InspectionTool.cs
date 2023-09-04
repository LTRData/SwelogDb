using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InspectionTool
{
    public string OperationList { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string InspectionToolNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ToolHeader InspectionToolNumberNavigation { get; set; } = null!;
}
