using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeManufacturingInspectionDtl
{
    public string OperationListId { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string MeasurePoint { get; set; } = null!;

    public string? MeasurePointDescription { get; set; }

    public decimal? Dimension { get; set; }

    public decimal? ToleranceLower { get; set; }

    public decimal? ToleranceUpper { get; set; }

    public string? ToolNumber { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ChangeManufacturingInspectionHdr Operation { get; set; } = null!;
}
