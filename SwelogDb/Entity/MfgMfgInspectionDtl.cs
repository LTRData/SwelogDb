using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgMfgInspectionDtl
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string MeasurePoint { get; set; } = null!;

    public string? MeasurePointDescription { get; set; }

    public decimal? Dimension { get; set; }

    public decimal? ToleranceLower { get; set; }

    public decimal? ToleranceUpper { get; set; }

    public string? ToolNumber { get; set; }

    public string? AuditStamp { get; set; }

    public string? Property { get; set; }

    public decimal? InspectionFrequency { get; set; }

    public string? ScOrCc { get; set; }

    public virtual MfgMfgInspectionHdr MfgMfgInspectionHdr { get; set; } = null!;
}
