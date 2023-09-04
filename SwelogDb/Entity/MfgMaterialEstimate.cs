using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgMaterialEstimate
{
    public string ItemNumber { get; set; } = null!;

    public short LotNumber { get; set; }

    public string ComponentPart { get; set; } = null!;

    public short OperationNumber { get; set; }

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

    public string? SplitDrawing { get; set; }

    public string? SplitPosition { get; set; }

    public string? ItemShape { get; set; }
}
