using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierAssessment
{
    public string SupplierId { get; set; } = null!;

    public int YearNo { get; set; }

    public string? Automotive { get; set; }

    public string? Iso9001 { get; set; }

    public string? Iso14001 { get; set; }

    public string? Ts16949 { get; set; }

    public string? NewAssessment { get; set; }

    public string? QualityAssessment { get; set; }

    public string? DeliveryPrecision { get; set; }

    public string? EnvironmentAssessment { get; set; }

    public string? FinalClass { get; set; }

    public int? NoOf8dReports { get; set; }

    public string? Homepage { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? N8dScoore { get; set; }

    public decimal? DeliveryTimeScore { get; set; }

    public decimal? QuantityScore { get; set; }

    public DateTime? Iso9001Date { get; set; }

    public DateTime? Iso14001Date { get; set; }

    public DateTime? Ts16949Date { get; set; }

    public string? NewAssessmentPathfile { get; set; }

    public decimal? TotalScoore { get; set; }

    public decimal? OwnScoore { get; set; }

    public decimal? QualityScoore { get; set; }

    public decimal? N8dScooreRepByCust { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;
}
