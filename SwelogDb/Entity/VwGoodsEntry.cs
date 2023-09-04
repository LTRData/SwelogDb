using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwGoodsEntry
{
    public string GoodsentryNo { get; set; } = null!;

    public DateTime ArrivalDate { get; set; }

    public DateTime? ProcessDatetime { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public decimal? DeliveryPart { get; set; }

    public string RefTranNo { get; set; } = null!;

    public string? RefTranId { get; set; }

    public string? ItemNumber { get; set; }

    public string? Location { get; set; }

    public string? PackageYn { get; set; }

    public string? CertificateDesc { get; set; }

    public string InvoiceNotExpectedYn { get; set; } = null!;

    public DateTime? ExpectedHandoverDate { get; set; }

    public DateTime? RealHandoverDate { get; set; }

    public string? SupplierName { get; set; }

    public decimal? DeliveryQty { get; set; }

    public string? DeliveryNoteNo { get; set; }

    public string? OrderNumber { get; set; }
}
