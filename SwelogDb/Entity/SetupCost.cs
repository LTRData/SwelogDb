using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SetupCost
{
    public string DeliveryNote { get; set; } = null!;

    public string ColorCode { get; set; } = null!;

    public string ServiceCode { get; set; } = null!;

    public string? ServiceDescription { get; set; }

    public decimal? Quantity { get; set; }

    public string? SaleUnit { get; set; }

    public decimal? SellingPrice { get; set; }

    public string? CurrencyCode { get; set; }

    public short? PriceUnit { get; set; }

    public string? VatCode { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Amount { get; set; }

    public string? AuditStamp { get; set; }
}
