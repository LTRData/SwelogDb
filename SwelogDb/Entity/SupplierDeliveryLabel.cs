using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierDeliveryLabel
{
    public int SerialNumber { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? ParentItem { get; set; }

    public string? ItemDescription { get; set; }

    public string? ConsigneeName { get; set; }

    public string? SenderName { get; set; }

    public decimal? NetWeight { get; set; }

    public decimal? GrossWeight { get; set; }

    public string? WeightUom { get; set; }

    public int? NoOfBoxes { get; set; }

    public decimal? QuantityPerBox { get; set; }

    public string? QuantityUom { get; set; }

    public string? SupplierId { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? OrderNumber { get; set; }

    public string? GateDescription { get; set; }

    public string? EnggChange { get; set; }

    public string? SuppliersItemNumber { get; set; }

    public string? PalletNo { get; set; }
}
