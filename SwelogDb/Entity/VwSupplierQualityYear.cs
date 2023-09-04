using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwSupplierQualityYear
{
    public string SupplierId { get; set; } = null!;

    public int? YearNo { get; set; }

    public int? QtyPointScore { get; set; }

    public int? DeliveryTimeScore { get; set; }

    public decimal? N8DRatingScoore { get; set; }

    public decimal? TotalScoore { get; set; }

    public string? YearSupplierGrade { get; set; }
}
