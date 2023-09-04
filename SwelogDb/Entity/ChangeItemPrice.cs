using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeItemPrice
{
    public string ItemNumber { get; set; } = null!;

    public string SupplierId { get; set; } = null!;

    public DateTime SupplierPriceValidFrom { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? SetUpCost { get; set; }

    public decimal? ExtraCostEstimate { get; set; }

    public decimal? ExtraCostEstimatePercent { get; set; }

    public DateTime? LastSellPriceChange { get; set; }

    public string? ReferenceId { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ChangeSupplierItem ChangeSupplierItem { get; set; } = null!;
}
