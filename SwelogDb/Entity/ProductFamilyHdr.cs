using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductFamilyHdr
{
    public string ProductFamilyCode { get; set; } = null!;

    public string? ProductFamilyName { get; set; }

    public decimal? AveragePrice { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ForecastFamily> ForecastFamilies { get; } = new List<ForecastFamily>();

    public virtual ICollection<ProdForecastDtl> ProdForecastDtls { get; } = new List<ProdForecastDtl>();

    public virtual ICollection<ProductFamilyDtl> ProductFamilyDtls { get; } = new List<ProductFamilyDtl>();
}
