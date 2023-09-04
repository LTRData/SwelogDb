using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerDeliveryDetailScrap
{
    public string DeliveryNoteNumber { get; set; } = null!;

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public string DeliveryAddressId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public double? DeliveryQuantity { get; set; }

    public string? WarehouseId { get; set; }

    public string? StockLocation { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? SellingPriceDelivery { get; set; }

    public decimal? DiscountPercentageDelivery { get; set; }

    public decimal? DeliveredAmount { get; set; }

    public decimal? ReceivedQuantity { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public decimal? NetWeight { get; set; }

    public string? WeightUom { get; set; }

    public decimal? NetVolume { get; set; }

    public string? VolumeUom { get; set; }

    public string? PacklistNumber { get; set; }

    public decimal? StockQuantity { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public string? InclInRecvAcc { get; set; }

    public string? InvoiceFlagItem { get; set; }

    public string? FinalDelivery { get; set; }

    public string? ParentItemNumber { get; set; }

    public string? DpPartConsignment { get; set; }

    public string? DoNotIncludeInIntrastat { get; set; }

    public decimal? InvoicedQty { get; set; }
}
