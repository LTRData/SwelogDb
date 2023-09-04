using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryStatisticsCu166
{
    public int SerialNumber { get; set; }

    public int? ProcessId { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? ItemNumber { get; set; }

    public string? ProductGroup { get; set; }

    public decimal? DeliveryQuantity { get; set; }

    public decimal? SellingPriceDelivery { get; set; }

    public decimal? CostPricePerUnit { get; set; }

    public decimal? RawMaterialCost { get; set; }

    public decimal? PurchaseCost { get; set; }

    public decimal? DirectWageCost { get; set; }

    public decimal? AverageHourlyEarning { get; set; }
}
