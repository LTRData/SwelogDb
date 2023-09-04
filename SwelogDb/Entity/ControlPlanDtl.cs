using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ControlPlanDtl
{
    public int SerialNumber { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string PartNumber { get; set; } = null!;

    public int OperationNumber { get; set; }

    public string? MeasurePoint { get; set; }

    public decimal? Dimension { get; set; }

    public string? Property { get; set; }

    public decimal? ToleranceLower { get; set; }

    public decimal? ToleranceUpper { get; set; }

    public string? MeasurementTechnique { get; set; }

    public decimal? InspectionFrequency { get; set; }

    public decimal? InspectionQuantity { get; set; }

    public string? Class { get; set; }

    public bool? Active { get; set; }
}
