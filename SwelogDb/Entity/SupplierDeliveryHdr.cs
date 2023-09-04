using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierDeliveryHdr
{
    public string DeliveryNoteNumber { get; set; } = null!;

    public string? PartnerId { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryStatus { get; set; }

    public decimal? PostageCharges { get; set; }

    public decimal? FreightCharges { get; set; }

    public decimal? PackagingCharges { get; set; }

    public string? InvoiceFlag { get; set; }

    public string? InvoiceSeries { get; set; }

    public decimal? InvoiceNumber { get; set; }

    public string? PrintoutNumber { get; set; }

    public string? FreightNote { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<SupplierDeliveryDtl> SupplierDeliveryDtls { get; } = new List<SupplierDeliveryDtl>();
}
