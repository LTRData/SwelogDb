using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NewDeliveryPlanHdrArchive
{
    public DateTime AcceptDate { get; set; }

    public string CustomerId { get; set; } = null!;

    public string DeliveryPlanId { get; set; } = null!;

    public DateTime? PlanDate { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerAdr1 { get; set; }

    public string? CustomerAdr2 { get; set; }

    public string? CustomerAdr3 { get; set; }

    public string? CustomerSuppNo { get; set; }

    public string? LpkAvskod { get; set; }

    public string? LpkAvskval { get; set; }

    public string? LpkMottkod { get; set; }

    public string? LpkMottkval { get; set; }

    public string? CustomerReference { get; set; }

    public string? PlanType { get; set; }

    public string? AuditStamp { get; set; }

    public string? PlanStatus { get; set; }
}
