using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PicklistHeader
{
    public string PicklistNumber { get; set; } = null!;

    public string? PartnerId { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? PrintoutNumber { get; set; }

    public string? DeliveryNote { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? UnifaunReturnSendingId { get; set; }

    public virtual Customer? Partner { get; set; }

    public virtual ICollection<PicklistDetail> PicklistDetails { get; } = new List<PicklistDetail>();
}
