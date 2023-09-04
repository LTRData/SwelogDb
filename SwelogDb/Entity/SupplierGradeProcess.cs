using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierGradeProcess
{
    public string Supplier { get; set; } = null!;

    public DateTime ProcessDatetime { get; set; }

    public int? ReferenceYearFrom { get; set; }

    public short? ReferenceMonthFrom { get; set; }

    public int? ReferenceYearTo { get; set; }

    public short? ReferenceMonthTo { get; set; }

    public decimal? N8dScoore { get; set; }

    public decimal? DeliveryTimeScore { get; set; }

    public decimal? QuantityScore { get; set; }

    public decimal? QualityScoore { get; set; }

    public decimal? OwnScoore { get; set; }

    public decimal? TotalScoore { get; set; }

    public string? FinalClass { get; set; }

    public decimal? N8dScooreRepByCust { get; set; }
}
