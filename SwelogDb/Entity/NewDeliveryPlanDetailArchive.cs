using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NewDeliveryPlanDetailArchive
{
    public DateTime AcceptDate { get; set; }

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

    public int IdNewDeliveryPlanDetailArchive { get; set; }

    public string? PartConsigment { get; set; }
}
