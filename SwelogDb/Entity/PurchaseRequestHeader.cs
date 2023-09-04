using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseRequestHeader
{
    public int IdPurchaseRequestHeader { get; set; }

    public string ModuleId { get; set; } = null!;

    public string? OfferNumber { get; set; }

    public string? ParentItemNumber { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectNumber { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? RequestStatus { get; set; }

    public string? AuditStamp { get; set; }

    public string? RequestedBy { get; set; }

    public DateTime? RequiredDate { get; set; }

    public string? ResponsibleId { get; set; }

    public string? DeliveryTerm { get; set; }

    public string? DeliveryTermCity { get; set; }

    public int? RequestDescriptionTxtid { get; set; }

    public int? SimulationLotNumber { get; set; }

    public DateTime? FollowupDate { get; set; }

    public string? PaymentTerm { get; set; }

    public string? CurrencyCode { get; set; }

    public virtual ICollection<PurchaseRequestDetail> PurchaseRequestDetails { get; } = new List<PurchaseRequestDetail>();
}
