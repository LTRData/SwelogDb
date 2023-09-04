using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerDeliveryHeader
{
    public string DeliveryNoteNumber { get; set; } = null!;

    public string? PartnerId { get; set; }

    public decimal? PostageCharges { get; set; }

    public decimal? FreightCharges { get; set; }

    public decimal? PackagingCharges { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? InvoiceFlag { get; set; }

    public string? InvoiceSeries { get; set; }

    public decimal? InvoiceNumber { get; set; }

    public string? PrintoutNumber { get; set; }

    public string? FreightNote { get; set; }

    public string? PrintFlag { get; set; }

    public string? PacklistNumber { get; set; }

    public string? DirectOrderNumber { get; set; }

    public decimal? GrossWeight { get; set; }

    public string? PicklistNumber { get; set; }

    public string? YourDeliveryNote { get; set; }

    public bool? CustomerConsignation { get; set; }

    public string? CreatedFrom { get; set; }

    public string? FreeText { get; set; }

    public string? PayMode { get; set; }

    public string? OnlyPrint { get; set; }

    public string? UnifaunReturnSendingId { get; set; }

    public string? FreeTextCoc { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ICollection<CustomerDeliveryDetail> CustomerDeliveryDetails { get; } = new List<CustomerDeliveryDetail>();

    public virtual ICollection<CustomerDeliveryPrecision> CustomerDeliveryPrecisions { get; } = new List<CustomerDeliveryPrecision>();
}
