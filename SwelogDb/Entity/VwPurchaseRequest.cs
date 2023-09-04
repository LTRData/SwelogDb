using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwPurchaseRequest
{
    public int RequestId { get; set; }

    public string ModuleId { get; set; } = null!;

    public string? SourceId { get; set; }

    public string? CrmId { get; set; }

    public string? CrmName { get; set; }

    public string? ParentItemNumber { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectNumber { get; set; }

    public string? RequestedBy { get; set; }

    public DateTime? RequestDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public string? ResponsibleId { get; set; }

    public string? RequestStatus { get; set; }

    public string HeaderSentYn { get; set; } = null!;

    public string HeaderReplyYn { get; set; } = null!;

    public string? SupplierId { get; set; }

    public string? ContactPerson { get; set; }

    public string? SentYn { get; set; }

    public DateTime? SentDate { get; set; }

    public string? SentBy { get; set; }

    public string? ReplyYn { get; set; }

    public DateTime? ReplyDate { get; set; }

    public DateTime? FollowupDate { get; set; }

    public decimal? Price { get; set; }

    public int? RequestDetailId { get; set; }

    public int? Quantity { get; set; }

    public string? Comments { get; set; }

    public int? CrmSerialNumber { get; set; }

    public int? ContactSerialNumber { get; set; }

    public string? ObjectDescription { get; set; }

    public string? PurchaseRequestNumber { get; set; }

    public string? DetailStatus { get; set; }

    public string? ItemDescription { get; set; }

    public decimal? Amount { get; set; }
}
