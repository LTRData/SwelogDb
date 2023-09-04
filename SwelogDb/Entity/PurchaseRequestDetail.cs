using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseRequestDetail
{
    public int IdPurchaseRequestDetail { get; set; }

    public int? HeaderId { get; set; }

    public string? SupplierId { get; set; }

    public string? ContactPerson { get; set; }

    public string? SentYn { get; set; }

    public DateTime? SentDate { get; set; }

    public string? SentBy { get; set; }

    public string? ReplyYn { get; set; }

    public string? Reply { get; set; }

    public DateTime? ReplyDate { get; set; }

    public decimal? Price { get; set; }

    public DateTime? FollowupDate { get; set; }

    public string? SelectedYn { get; set; }

    public int? RequestTextId { get; set; }

    public int? Quantity { get; set; }

    public string? Comments { get; set; }

    public string? AuditStamp { get; set; }

    public string? PaymentTerm { get; set; }

    public int? CrmSerialNumber { get; set; }

    public int? ContactSerialNumber { get; set; }

    public string? LanguageCode { get; set; }

    public int? AnnualRequirement { get; set; }

    public int? SubOrderQuantity { get; set; }

    public int? PriceUnitNum { get; set; }

    public string? CurrencyCode { get; set; }

    public string? DeliveryTerm { get; set; }

    public string? DeliveryTermCity { get; set; }

    public DateTime? RequiredDate { get; set; }

    public string? PurchaseRequestNumber { get; set; }

    public string? DetailStatus { get; set; }

    public decimal? SpeccostFreight { get; set; }

    public virtual PurchaseRequestHeader? Header { get; set; }
}
