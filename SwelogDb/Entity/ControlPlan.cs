using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ControlPlan
{
    public string ProjectNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public int SerialNumber { get; set; }

    public string? PartNumber { get; set; }

    public int? OperationNumber { get; set; }

    public string? OperationDescription { get; set; }

    public string? ToolNumber { get; set; }

    public string? MeasurePoint { get; set; }

    public decimal? Dimension { get; set; }

    public string? Property { get; set; }

    public decimal? ToleranceLower { get; set; }

    public decimal? ToleranceUpper { get; set; }

    public string? ProcessSpecificationTolerance { get; set; }

    public string? MeasurementTechnique { get; set; }

    public string? ControlMethod { get; set; }

    public string? ReactionPlan { get; set; }

    public decimal? InspectionFrequency { get; set; }

    public decimal? InspectionQuantity { get; set; }

    public string ProjectItemNumber { get; set; } = null!;

    public string RevisionNo { get; set; } = null!;

    public int? PfmeaBranchId { get; set; }
}
