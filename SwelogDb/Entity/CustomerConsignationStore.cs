using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerConsignationStore
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
}
