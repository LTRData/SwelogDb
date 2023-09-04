using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PoSuggestResultReportHistory
{
    public DateTime HistoryDate { get; set; }

    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public string? PlannerId { get; set; }

    public string? MainSupplier { get; set; }

    public decimal? CurrentBalance { get; set; }

    public string? StockingUnit { get; set; }

    public string? PurchaseOrder { get; set; }

    public decimal? OrderQuantity { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public DateTime? RaiseDate { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public DateTime? NewDeliveryDate { get; set; }

    public int? RaiseDateYyyywwd { get; set; }

    public int? PlDelvDateYyyywwd { get; set; }

    public int? NewDelvDateYyyywwd { get; set; }

    public string? Code { get; set; }

    public string? Status { get; set; }

    public string? TransferFlag { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? OrderLine { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime BackupCreatedOn { get; set; }
}
