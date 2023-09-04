using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwContractOrderItemCall
{
    public string? CustomerNo { get; set; }

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string CallStatus { get; set; } = null!;

    public DateTime? PlannedDeliveryDate { get; set; }

    public decimal? ExchRateForSales { get; set; }

    public decimal? SellingPriceStockUnitFcGross { get; set; }

    public decimal? SellingPriceStockUnitFcNet { get; set; }

    public double? OrderedQuantity { get; set; }

    public double? DeliveredQuantity { get; set; }

    public double? OrderedAmtGrossFc { get; set; }

    public double? OrderedAmtNetFc { get; set; }

    public double? OrderedAmtGrossBc { get; set; }

    public double? OrderedAmtNetBc { get; set; }

    public double? DeliveredAmtGrossFc { get; set; }

    public double? DeliveredAmtNetFc { get; set; }

    public double? DeliveredAmtGrossBc { get; set; }

    public double? DeliveredAmtNetBc { get; set; }

    public DateTime? LastDeliveredDate { get; set; }

    public DateTime? PromisedDeliveryDate { get; set; }

    public string DeliveryStatus { get; set; } = null!;

    public string OrderLineStatus { get; set; } = null!;
}
