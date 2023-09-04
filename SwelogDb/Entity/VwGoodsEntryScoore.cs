using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwGoodsEntryScoore
{
    public string OrderNumber { get; set; } = null!;

    public string? SupplierId { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string GoodsentryNo { get; set; } = null!;

    public int? PerYear { get; set; }

    public int? PerMonth { get; set; }

    public decimal? DeliveryQtyPurchUnit { get; set; }

    public decimal? OrderQuantity { get; set; }

    public decimal? QuantityGenerated { get; set; }

    public decimal? QtyRate { get; set; }

    public short? QtyPointScore { get; set; }

    public decimal? QuantityWght { get; set; }

    public decimal? QuantityScoore { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public DateTime? PromisedDeliveryDate { get; set; }

    public DateTime? AvailableDate { get; set; }

    public int? Delayment { get; set; }

    public short? DeliveryTimeScore { get; set; }

    public decimal? TimeWght { get; set; }

    public decimal? TimeScoore { get; set; }

    public decimal? QualityScore { get; set; }

    public decimal? QualityWght { get; set; }

    public decimal? QualityScoore { get; set; }

    public int? N8dReports { get; set; }

    public int? N8dReportsRepByCust { get; set; }

    public decimal? N8DRatingGrade { get; set; }

    public decimal? N8DRatingGradeRepByCust { get; set; }

    public decimal? N8dWght { get; set; }

    public decimal? N8dWghtRepByCust { get; set; }

    public decimal? N8DRatingScoore { get; set; }

    public decimal? N8DRatingScooreRepByCust { get; set; }

    public decimal? OwnGrade { get; set; }

    public decimal? OwnWght { get; set; }

    public decimal? OwnScoore { get; set; }

    public decimal? TotalScoore { get; set; }

    public string? QuantityRatingId { get; set; }

    public string? DeliveryTimeRatingId { get; set; }

    public int? YearNo { get; set; }

    public decimal? SupplyQuality { get; set; }

    public int? QualityPoint { get; set; }

    public int IdPurchaseOrderDtl { get; set; }
}
