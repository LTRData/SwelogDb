using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SysparamPurchase
{
    public string CompanyId { get; set; } = null!;

    public string? GoodsReferenceCode { get; set; }

    public string? InvoiceReferenceCode { get; set; }

    public string? InvRoutingReferenceCode { get; set; }

    public string? GeneralReferenceCode { get; set; }

    public string? PurchaseOrderCode { get; set; }

    public string? HiredResourceType { get; set; }

    public string? AuditStamp { get; set; }

    public int? PurchOprSelectionDisplayDaysAhead { get; set; }
}
