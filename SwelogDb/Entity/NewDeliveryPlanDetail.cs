using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NewDeliveryPlanDetail
{
    public string CustomerId { get; set; } = null!;

    public string DeliveryPlanId { get; set; } = null!;

    public string ItemNo { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public DateTime DeliveryDatetime { get; set; }

    public decimal? RequiredQty { get; set; }

    public string? OrderStatus { get; set; }

    public string? AuditStamp { get; set; }

    public string? CustomerOrderNo { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? ContractOrderType { get; set; }

    public int IdNewDeliveryPlanDetail { get; set; }

    public string? PartConsigment { get; set; }

    public string? PacklistNumber { get; set; }

    public decimal? AutodeductedQty { get; set; }

    public short? PicklistDtlLineNo { get; set; }

    public string? Callno { get; set; }

    public virtual NewDeliveryPlanHdr NewDeliveryPlanHdr { get; set; } = null!;
}
