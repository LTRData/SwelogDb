using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpSuppInvHdrFromXml
{
    public int ProcessId { get; set; }

    public string? SupplierNo { get; set; }

    public string? VendorId { get; set; }

    public string? VendorId2 { get; set; }

    public string? VendorId3 { get; set; }

    public string? VendorId4 { get; set; }

    public string? VendorId5 { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? InvAmountFc { get; set; }

    public decimal? VatAmountFc { get; set; }

    public string? OcrNo { get; set; }

    public string? InvoiceType { get; set; }

    public string? CurrencyCode { get; set; }

    public string? MultipleSuppFlag { get; set; }
}
