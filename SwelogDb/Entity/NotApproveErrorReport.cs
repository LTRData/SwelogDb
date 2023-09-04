using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NotApproveErrorReport
{
    public string ReportId { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public short TranType { get; set; }

    public DateTime ReportDateTime { get; set; }

    public int? ReportedBy { get; set; }

    public string? PalletNo { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public decimal? QtyProcessed { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public string? DeviationText { get; set; }

    public bool? AffectsOtherItems { get; set; }

    public string? AffectedItems { get; set; }

    public string? InspectionComments { get; set; }

    public string? InspectionIncharge { get; set; }

    public DateTime? InspectionPlannedDate { get; set; }

    public DateTime? InspectionApprovedDate { get; set; }

    public string? Action1Comments { get; set; }

    public string? Action1Incharge { get; set; }

    public DateTime? Action1PlannedDate { get; set; }

    public DateTime? Action1Date { get; set; }

    public string? Action2Comments { get; set; }

    public string? Action2Incharge { get; set; }

    public DateTime? Action2PlannedDate { get; set; }

    public DateTime? Action2Date { get; set; }

    public string? Action3Comments { get; set; }

    public string? Action3Incharge { get; set; }

    public DateTime? Action3PlannedDate { get; set; }

    public DateTime? Action3Date { get; set; }

    public string? Action4Comments { get; set; }

    public string? Action4Incharge { get; set; }

    public DateTime? Action4PlannedDate { get; set; }

    public DateTime? Action4Date { get; set; }

    public string? Action4Quantity { get; set; }

    public string? Action5Comments { get; set; }

    public string? Action5Incharge { get; set; }

    public DateTime? Action5PlannedDate { get; set; }

    public DateTime? Action5Date { get; set; }

    public string? Action6Comments { get; set; }

    public string? Action6Incharge { get; set; }

    public DateTime? Action6PlannedDate { get; set; }

    public DateTime? Action6Date { get; set; }

    public string? Action7Comments { get; set; }

    public string? Action7Incharge { get; set; }

    public DateTime? Action7PlannedDate { get; set; }

    public DateTime? Action7Date { get; set; }

    public string? Action8Comments { get; set; }

    public string? Action8Incharge { get; set; }

    public DateTime? Action8PlannedDate { get; set; }

    public DateTime? Action8Date { get; set; }

    public string? ItemDescription { get; set; }

    public string? ReportType { get; set; }

    public string? PartnerId { get; set; }

    public string? PartnerName { get; set; }

    public string? PartnerReportNo { get; set; }

    public string? PartnerItemNumber { get; set; }

    public string? PartnerReference { get; set; }

    public string? CausingDepartmentId { get; set; }

    public string? MeasuringDepartmentId { get; set; }

    public string? ReportedDepartmentId { get; set; }

    public string? OurReference { get; set; }

    public decimal? QtyAfterInvestigation { get; set; }

    public string? BatchNumber { get; set; }

    public string? ReworkBatchNumber { get; set; }

    public decimal? Cost { get; set; }

    public string? StockingUnit { get; set; }

    public int? LatestReworkLotNumber { get; set; }

    public string? ReportStatus { get; set; }

    public string? PartnerType { get; set; }

    public string? LotNumberList { get; set; }

    public string? DeviationCode { get; set; }

    public string? DisapprovedByPartner { get; set; }

    public decimal? SellingPrice { get; set; }

    public string? OrderNumber { get; set; }

    public bool? UpdateFmea { get; set; }

    public string? NotApproveCode { get; set; }

    public string? UpdateFmeaText { get; set; }

    public string? UpdateFmeaReportBy { get; set; }

    public DateTime? UpdateFmeaDate { get; set; }

    public string? ReportedByCustomer { get; set; }

    public string? Action4bComments { get; set; }

    public string? Action4bIncharge { get; set; }

    public DateTime? Action4bPlannedDate { get; set; }

    public DateTime? Action4bDate { get; set; }

    public string? Action5bComments { get; set; }

    public string? Action5bIncharge { get; set; }

    public DateTime? Action5bPlannedDate { get; set; }

    public DateTime? Action5bDate { get; set; }

    public int? VersionNo { get; set; }

    public int? Action1TodoPriorityNo { get; set; }

    public int? Action2TodoPriorityNo { get; set; }

    public int? Action3TodoPriorityNo { get; set; }

    public int? Action4TodoPriorityNo { get; set; }

    public int? Action5TodoPriorityNo { get; set; }

    public int? Action6TodoPriorityNo { get; set; }

    public int? Action7TodoPriorityNo { get; set; }

    public int? Action8TodoPriorityNo { get; set; }

    public string? ReturnOrderNumber { get; set; }

    public short? ReturnOrderLineNumber { get; set; }

    public DateTime? OriginDate { get; set; }

    public virtual ICollection<NotApproveErrorCost> NotApproveErrorCosts { get; } = new List<NotApproveErrorCost>();
}
