using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwCustomerConsignation
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? CustomerId { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public decimal? TotalQuantity { get; set; }

    public string? CcPalletNo { get; set; }

    public string? ConsignationStoreLocation { get; set; }

    public string? GeneratedFromPalletNo { get; set; }

    public string? SourceStoreLocation { get; set; }

    public string? SourceStockPosition { get; set; }

    public string? CurrentStatus { get; set; }

    public decimal? QuantityInCc { get; set; }

    public int? QuantityMoved { get; set; }

    public int? QuantityInvoiced { get; set; }

    public int? QuantityPendingToInvoice { get; set; }

    public string? UomFormat { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Datemask { get; set; }
}
