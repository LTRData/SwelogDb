using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CompactStoreOut
{
    public int RecNo { get; set; }

    public string? OrderNo { get; set; }

    public int? OrderlineNo { get; set; }

    public string? SalesOrderNo { get; set; }

    public int? SalesOrderlineNo { get; set; }

    public decimal? ActQuantity { get; set; }

    public short? PartialDelivery { get; set; }
}
