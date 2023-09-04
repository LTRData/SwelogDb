using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwGoodsEntryScooreYear
{
    public string? SupplierId { get; set; }

    public int? YearNo { get; set; }

    public decimal? QuantityScoore { get; set; }

    public decimal? DeliveryTimeScore { get; set; }

    public decimal? N8DRatingScoore { get; set; }

    public decimal? N8DRatingScooreRepByCust { get; set; }

    public decimal? OwnScoore { get; set; }

    public decimal? QualityScoore { get; set; }

    public decimal? TotalScoore { get; set; }

    public string? YearSupplierGrade { get; set; }
}
