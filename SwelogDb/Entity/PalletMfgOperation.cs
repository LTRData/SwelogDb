using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletMfgOperation
{
    public string PalletNo { get; set; } = null!;

    public DateTime? RegDate { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public int OperationNumber { get; set; }

    public string? StoreLocation { get; set; }

    public string? StockPosition { get; set; }

    public int? DeviationTxtid { get; set; }

    public int? DeviationRepBy { get; set; }

    public DateTime? DeviationRepDate { get; set; }

    public DateTime? DeviationReviewDate { get; set; }

    public decimal? DeviationReviewQuantity { get; set; }

    public string? ErrorReportId { get; set; }

    public string? DeviationFlag { get; set; }

    public string? AuditStamp { get; set; }

    public int? QtyAdjusted { get; set; }

    public int? DeviationReviewBy { get; set; }

    public int? ReworkLotNumber { get; set; }

    public int? ParentOperationNumber { get; set; }

    public int? ParentLotNumber { get; set; }

    public int? Quantity { get; set; }

    public int? QuantityIssued { get; set; }

    public decimal? CostPrice { get; set; }

    public string? InspectionId { get; set; }

    public int? InspectionSerial { get; set; }

    public string? NotApproveCode { get; set; }

    public string? OriginalPalletNo { get; set; }

    public decimal? TotaccumComponentCost { get; set; }

    public decimal? TotaccumWagecost { get; set; }

    public decimal? TotaccumOther { get; set; }

    public decimal? TotaccumAlloyCost { get; set; }

    public string? ResourceNumber { get; set; }

    public int? ReportedBy { get; set; }
}
