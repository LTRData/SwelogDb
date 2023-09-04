using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferPurchaseRequest
{
    public int IdOfferPurchaseRequest { get; set; }

    public string? OfferNumber { get; set; }

    public string? ParentItemNumber { get; set; }

    public string? OperationItemFlag { get; set; }

    public string? OperationItemNumber { get; set; }

    public string? SupplierId { get; set; }

    public string? ContactPerson { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? RequestStatus { get; set; }

    public string? Reply { get; set; }

    public DateTime? ReplyDate { get; set; }

    public decimal? Price { get; set; }

    public DateTime? FollowupDate { get; set; }

    public string? SelectedYn { get; set; }

    public string? AuditStamp { get; set; }

    public virtual OfferHeader? OfferNumberNavigation { get; set; }
}
