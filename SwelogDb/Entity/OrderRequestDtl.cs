using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderRequestDtl
{
    public int RequestSerialNumber { get; set; }

    public int SerialNumber { get; set; }

    public string? PackageEan { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public string? AuditStamp { get; set; }

    public virtual OrderRequestHdr RequestSerialNumberNavigation { get; set; } = null!;
}
