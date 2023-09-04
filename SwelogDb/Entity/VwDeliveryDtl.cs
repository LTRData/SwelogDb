using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwDeliveryDtl
{
    public string DeliveryType { get; set; } = null!;

    public string? DeliveryNoteNumber { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? ItemNumber { get; set; }

    public string? DelnoteKey { get; set; }

    public string? ReceiverDeladdrKey { get; set; }

    public string? SenderDeladdrKey { get; set; }

    public string? OrderKey { get; set; }

    public double? DeliveryQuantity { get; set; }

    public string? StockLocation { get; set; }

    public decimal? SellingPriceDelivery { get; set; }

    public decimal? DiscountPercentageDelivery { get; set; }

    public decimal? DeliveredAmount { get; set; }

    public decimal? ReceivedQuantity { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public decimal? NetWeight { get; set; }

    public string? WeightUom { get; set; }

    public decimal? NetVolume { get; set; }

    public string? PacklistNumber { get; set; }

    public decimal? StockQuantity { get; set; }

    public string? PartnerOrderNumber { get; set; }
}
