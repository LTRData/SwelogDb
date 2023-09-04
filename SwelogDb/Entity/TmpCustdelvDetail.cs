using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpCustdelvDetail
{
    public int ProcessId { get; set; }

    public int RowId { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? OrderLineType { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? ParentItemNumber { get; set; }

    public decimal? ParentDeliveredQuantity { get; set; }

    public string? PartnerId { get; set; }

    public string? StoreLocation { get; set; }

    public string? PacklistNumber { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public string? YourDeliveryNote { get; set; }

    public string? CcPalletNo { get; set; }

    public string? Userid { get; set; }

    public string? Workstation { get; set; }

    public string? PicklistNumber { get; set; }
}
