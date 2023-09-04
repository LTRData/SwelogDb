using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceMaster
{
    public string CompanyId { get; set; } = null!;

    public string ResourceNo { get; set; } = null!;

    public string? ResourceDescription { get; set; }

    public string? ResourceType { get; set; }

    public decimal? AverageHourlyEarning { get; set; }

    public decimal? ResourceRate { get; set; }

    public decimal? FinancialCost { get; set; }

    public decimal? DepresCost { get; set; }

    public decimal? ReobtainaddCost { get; set; }

    public decimal? OverheadPercentage { get; set; }

    public decimal? Manning { get; set; }

    public string? AuditStamp { get; set; }

    public string? DocumentPath { get; set; }

    public string? CostCentre { get; set; }

    public string? SubfolderField { get; set; }

    public int? InactiveFlag { get; set; }

    public string? ResourceType2 { get; set; }
}
