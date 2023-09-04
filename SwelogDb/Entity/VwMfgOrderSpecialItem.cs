using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwMfgOrderSpecialItem
{
    public string MoNumber { get; set; } = null!;

    public string MoItem { get; set; } = null!;

    public int MoLot { get; set; }

    public short MoOp { get; set; }

    public short SequenceNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public DateTime? DemandDate { get; set; }

    public decimal? ItemRequiredQuantity { get; set; }

    public string? Uom { get; set; }

    public decimal? Price { get; set; }

    public string? SupplierId { get; set; }

    public string? PlannerId { get; set; }

    public string OrderedYn { get; set; } = null!;

    public string? InternalGoodsReceiver { get; set; }

    public int? PriceUnitNum { get; set; }
}
