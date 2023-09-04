using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryGoodsDesc
{
    public string GoodsDescCode { get; set; } = null!;

    public string? GoodsDesc { get; set; }

    public int? GoodsTxtid { get; set; }

    public string? AuditStamp { get; set; }

    public string? DefaultInFreightnote { get; set; }
}
