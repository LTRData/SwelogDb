using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeMaterialEstimate
{
    public string ParentPart { get; set; } = null!;

    public string ComponentPart { get; set; } = null!;

    public string PositionIndicator { get; set; } = null!;

    public short OperationNo { get; set; }

    public short SplitSequence { get; set; }

    public decimal? SplitQuantity { get; set; }

    public decimal? EstimateLength { get; set; }

    public decimal? EstimateBredth { get; set; }

    public decimal? EstimateThickness { get; set; }

    public decimal? PercentageWaste { get; set; }

    public string? EstimateDesc { get; set; }

    public int? EstimateDescTxtid { get; set; }

    public string? EstimateDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? UomCode { get; set; }
}
