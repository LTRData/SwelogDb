using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwOrderHdr
{
    public string PartnerOrderType { get; set; } = null!;

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public string? OrderKey { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? PartnerId { get; set; }

    public string? PartnerKey { get; set; }

    public string? OeTemplateId { get; set; }

    public int? MailingAddressNo { get; set; }

    public int? ElectronicAddressNo { get; set; }

    public string? CurrencyCode { get; set; }

    public string? LanguageCode { get; set; }

    public string? OurReference { get; set; }

    public string? TheirReference { get; set; }

    public string? TransportModeCode { get; set; }

    public string? PartnerOwnOrderNo { get; set; }

    public string? YourReference { get; set; }

    public string? GoodsMarking { get; set; }

    public string? FreightPayType { get; set; }

    public string? PartnerReferenceKey { get; set; }

    public string? PaymentTermDescription { get; set; }
}
