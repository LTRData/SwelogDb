using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferDetail
{
    public string OfferNumber { get; set; } = null!;

    public short LineNumber { get; set; }

    public string? LineType { get; set; }

    public string? ItemNumber { get; set; }

    public string? GoodsDescription { get; set; }

    public int? GoodsDescriptionTxtid { get; set; }

    public decimal? Quantity { get; set; }

    public string? UnitOfSale { get; set; }

    public decimal? SellingPrice { get; set; }

    public string? AuditStamp { get; set; }
}
