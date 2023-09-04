using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryPallet1
{
    public string DeliveryPalletNo { get; set; } = null!;

    public DateTime DeliveryTimestamp { get; set; }

    public string? DeliveryIdentification { get; set; }

    public string? DeliveryType { get; set; }

    public decimal? DeliveryQuantity { get; set; }

    public string PalletNo { get; set; } = null!;

    public DateTime? RegDate { get; set; }

    public string? Warehouse { get; set; }

    public string? Location { get; set; }

    public string? OwnerType { get; set; }

    public string? Owner { get; set; }

    public string? LotNo { get; set; }

    public string? OrderNo { get; set; }

    public decimal? Price { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? Item { get; set; }

    public string? Status { get; set; }

    public string? ControlId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? QuantityIssued { get; set; }

    public DateTime? LastChangedDt { get; set; }

    public string? ItemRevNo { get; set; }

    public string? DrawingNo { get; set; }

    public string? DrawingRevNo { get; set; }

    public decimal? PalletCapitalCost { get; set; }

    public decimal? PalletReworkCost { get; set; }

    public decimal? QtyReserved { get; set; }

    public string? CurrLoc { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? RejectedQty { get; set; }

    public decimal? RecvdQtyCoReturn { get; set; }

    public string? VinNumber { get; set; }

    public DateTime? VinReportDate { get; set; }

    public decimal? PalletCost { get; set; }

    public decimal? PalletCostIssued { get; set; }

    public string? ComplaintNo { get; set; }

    public string? ErrorReportId { get; set; }

    public string? CertificateDesc { get; set; }

    public decimal? Breadth { get; set; }

    public string? Comments { get; set; }

    public string? CustomerOrderLine { get; set; }

    public decimal? PurchasePrice { get; set; }

    public decimal? FreightPrice { get; set; }

    public decimal? TaxPrice { get; set; }

    public decimal? ConsPrice { get; set; }

    public decimal? VatPrice { get; set; }

    public decimal? ClearancePrice { get; set; }

    public decimal? ImportPrice { get; set; }

    public int? ClearanceNumber { get; set; }

    public string? CertificateFilename { get; set; }

    public string? EcnNumber { get; set; }
}
