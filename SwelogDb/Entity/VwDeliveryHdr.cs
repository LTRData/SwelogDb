using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwDeliveryHdr
{
    public string DeliveryType { get; set; } = null!;

    public string? DeliveryNoteNumber { get; set; }

    public string? DelnoteKey { get; set; }

    public string? PartnerId { get; set; }

    public string? PartnerKey { get; set; }

    public string? OrderKey { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public decimal? PostageCharges { get; set; }

    public decimal? FreightCharges { get; set; }

    public decimal? PackagingCharges { get; set; }

    public string? InvoiceFlag { get; set; }

    public string? InvoiceSeries { get; set; }

    public decimal? InvoiceNumber { get; set; }

    public string? PrintoutNumber { get; set; }

    public string? FreightNote { get; set; }

    public string? PicklistNumber { get; set; }

    public string? YourDeliveryNote { get; set; }

    public string? AuditStamp { get; set; }
}
