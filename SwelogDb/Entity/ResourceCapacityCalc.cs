using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceCapacityCalc
{
    public string CostCentre { get; set; } = null!;

    public string ProductionGroupId { get; set; } = null!;

    public string ResourceNo { get; set; } = null!;

    public short Year { get; set; }

    public short WeekNo { get; set; }

    public short MonthNo { get; set; }

    public string? ResourceDescription { get; set; }

    public decimal AvailableTime { get; set; }

    public decimal UtilisationDegree { get; set; }

    public decimal Efficiency { get; set; }

    public decimal ResourceCapacity { get; set; }

    public decimal UtilisationDegreeCalc { get; set; }

    public decimal EfficiencyCalc { get; set; }

    public decimal ResourceCapacityCalc1 { get; set; }

    public decimal? EfficiencyUsedTime { get; set; }

    public decimal? EfficiencyPlannedTime { get; set; }

    public decimal? UtilisationDegreeUsedTime { get; set; }
}
