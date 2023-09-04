using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SweDelPlanSuppDelplanAdvise
{
    public int RecNo { get; set; }

    public DateTime? ProcessDatetime { get; set; }

    public int? XfrId { get; set; }

    public string? SupplierId { get; set; }

    public string? ContractOrderNo { get; set; }

    public string? DeliveryNoteNo { get; set; }

    public DateTime? DespatchDate { get; set; }

    public string? ItemNumber { get; set; }

    public short? LineNumber { get; set; }

    public decimal? DeliveryQty { get; set; }

    public string? SerialNo { get; set; }

    public string? ValidRecord { get; set; }

    public string? GoodsentryNo { get; set; }

    public string? OrderNumber { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public DateTime? AvailableDate { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public decimal? OrderQuantity { get; set; }
}
