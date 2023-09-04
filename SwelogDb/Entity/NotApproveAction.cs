using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NotApproveAction
{
    public string ResourceNumber { get; set; } = null!;

    public string? ResourceDescription { get; set; }

    public DateTime ReportDateTime { get; set; }

    public string? ActivityNo { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public string? OperationDesc { get; set; }

    public int? ReportedBy { get; set; }

    public string ProductionGroupId { get; set; } = null!;

    public string NotApproveCode { get; set; } = null!;

    public string? NotApproveDescription { get; set; }

    public decimal? OrderedQuantity { get; set; }

    public decimal? QtyProduced { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public int SequenceNo { get; set; }

    public DateTime ReviewDate { get; set; }

    public int? ReviewedBy { get; set; }

    public string DeviationCode { get; set; } = null!;

    public string? DeviationDesc { get; set; }

    public string ReviewAction { get; set; } = null!;

    public decimal? QtyReviewed { get; set; }

    public string? ActionRoute { get; set; }

    public string? ReviewComment { get; set; }

    public int? ActionCommentTextid { get; set; }

    public decimal? DirectWage { get; set; }

    public decimal? OtherCost { get; set; }

    public decimal? ComponentCost { get; set; }

    public string? DismountFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? QuantityFormat { get; set; }

    public string? ReworkDecisionFlag { get; set; }

    public int? OperationDescTxtid { get; set; }

    public int RecordSerial { get; set; }

    public string? ErrorReportId { get; set; }

    public int? TranType { get; set; }

    public string? ReferenceNo { get; set; }

    public int? ReworkLotNumber { get; set; }

    public int? ExtraOperationNumber { get; set; }

    public string? PalletNo { get; set; }

    public decimal? QtyAdjusted { get; set; }
}
