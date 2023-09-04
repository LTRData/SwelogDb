using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PrognosPlan
{
    public string ItemNumber { get; set; } = null!;

    public string OrderNo { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public DateTime RequiredDate { get; set; }

    public decimal? RequiredQtyPrognos { get; set; }

    public decimal? RequiredQtyActual { get; set; }

    public string? ParentItem { get; set; }

    public DateTime? ParentReqdDate { get; set; }

    public string? Owner { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? DelplanOrderStatus { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public string? AuditStamp { get; set; }

    public string? ActiveFlag { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public int Iden { get; set; }

    public virtual CurrentDeliveryPlanHdr CurrentDeliveryPlanHdr { get; set; } = null!;
}
