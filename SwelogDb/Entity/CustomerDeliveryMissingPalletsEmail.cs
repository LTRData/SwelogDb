using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerDeliveryMissingPalletsEmail
{
    public int RecNo { get; set; }

    public int? KeyIdentifier { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? CustomerNo { get; set; }

    public string? SupplierId { get; set; }

    public string? PurchaseOrderNo { get; set; }

    public string? PalletNoArr { get; set; }

    public string? EmailSent { get; set; }

    public string? AuditStamp { get; set; }

    public string? ManualDelivery { get; set; }
}
