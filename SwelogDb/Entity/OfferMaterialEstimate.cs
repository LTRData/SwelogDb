using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferMaterialEstimate
{
    public int IdOfferMaterialEstimate { get; set; }

    public string? ParentPart { get; set; }

    public int? SimulationLotNumber { get; set; }

    public string? ComponentPart { get; set; }

    public string? UomCode { get; set; }

    public decimal? SplitQuantity { get; set; }

    public string? ItemShape { get; set; }

    public decimal? EstimateLength { get; set; }

    public decimal? EstimateBreadth { get; set; }

    public decimal? EstimateThickness { get; set; }

    public decimal? PercentageWaste { get; set; }

    public string? SplitDrawing { get; set; }

    public string? SplitPosition { get; set; }

    public string? EstimateDesc { get; set; }

    public int? EstimateDescTxtid { get; set; }

    public string? AuditStamp { get; set; }
}
