using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GoodsClasification
{
    public string TariffCode { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? DescriptionTxtid { get; set; }

    public string? OtherQuantity { get; set; }

    public string? UnitOfMeasure { get; set; }

    public string? AuditStamp { get; set; }
}
