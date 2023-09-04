using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvAttestFreightNote
{
    public int RecNo { get; set; }

    public string? CompanyNo { get; set; }

    public string? InvoiceType { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? FreightNote { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryType { get; set; }

    public string? PartnerId { get; set; }

    public string? SupplierNoInCo { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? TotalVolume { get; set; }

    public int? NoOfPallets { get; set; }

    public string? AuditStamp { get; set; }
}
