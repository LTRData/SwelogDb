using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbPriceFactor
{
    public string ClassId { get; set; } = null!;

    public string MaterialId { get; set; } = null!;

    public decimal PriceFactorStd { get; set; }

    public decimal PriceFactorSpl { get; set; }

    public string? AuditStamp { get; set; }
}
