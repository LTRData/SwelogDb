using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustReceiptDeliveryNote
{
    public string CustomerId { get; set; } = null!;

    public string ItemNo { get; set; } = null!;

    public string DeliveryNoteNo { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public DateTime? DeliveryNoteDate { get; set; }

    public decimal? DeliveredQty { get; set; }

    public decimal? ReceiptQty { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public DateTime? PdnDatetime { get; set; }

    public string? AuditStamp { get; set; }

    public string? OrderNumber { get; set; }

    public string? OrderType { get; set; }

    public string? AcceptanceFlag { get; set; }

    public int IdCustReceiptDeliveryNote { get; set; }

    public int? CustomersReceivalId { get; set; }

    public string? PicklistNumber { get; set; }
}
