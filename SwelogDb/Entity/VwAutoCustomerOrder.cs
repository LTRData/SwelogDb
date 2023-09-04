using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwAutoCustomerOrder
{
    public string OrderNumber { get; set; } = null!;

    public string? OurReference { get; set; }

    public string? CustomerName { get; set; }

    public string? ItemNumber { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public decimal? OrderQuantity { get; set; }

    public decimal? SellingPrice { get; set; }

    public short? PriceUnit { get; set; }
}
