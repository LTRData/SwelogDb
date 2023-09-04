using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CurrentDeliveryPlanHdr
{
    public string OrderNo { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public string ItemNo { get; set; } = null!;

    public string? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? ContractType { get; set; }

    public string? OurPartyId { get; set; }

    public virtual Item ItemNoNavigation { get; set; } = null!;

    public virtual ICollection<PrognosPlan> PrognosPlans { get; } = new List<PrognosPlan>();
}
