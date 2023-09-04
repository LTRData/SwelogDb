using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierItemOperationQuality
{
    public string SupplierId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public short OperationNumber { get; set; }

    public DateTime ArrivalDate { get; set; }

    public string GoodsentryNo { get; set; } = null!;

    public string? WrongQtyDelivered { get; set; }

    public short? QtyPointScore { get; set; }

    public string? WrongTimeDelivered { get; set; }

    public short? DeliveryTimeScore { get; set; }

    public string? RejectionIndicator { get; set; }

    public decimal? QualityScore { get; set; }

    public string? ReclamationIndicator { get; set; }

    public string? PartDeliveryIndicator { get; set; }

    public decimal? QuantityWght { get; set; }

    public decimal? TimeWght { get; set; }

    public decimal? QualityWght { get; set; }

    public decimal? OwnWght { get; set; }

    public decimal? N8dWght { get; set; }

    public decimal? OwnScoore { get; set; }

    public decimal? N8DRatingScoore { get; set; }

    public decimal? TotalScoore { get; set; }

    public decimal? N8dWghtRepByCust { get; set; }

    public decimal? N8DRatingScooreRepByCust { get; set; }

    public decimal? SupplyQuality { get; set; }

    public int? QualityPoint { get; set; }
}
