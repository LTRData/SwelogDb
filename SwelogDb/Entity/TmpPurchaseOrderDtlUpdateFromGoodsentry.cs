using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpPurchaseOrderDtlUpdateFromGoodsentry
{
    public int IdTmpPurchaseOrderDtlUpdateFromGoodsentry { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public string? GoodsentryDeliveryStatus { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? OrderLineStatus { get; set; }

    public decimal? OrderedStockUnits { get; set; }

    public decimal? DeliveredStockUnits { get; set; }

    public DateTime? ProcessDatetime { get; set; }
}
