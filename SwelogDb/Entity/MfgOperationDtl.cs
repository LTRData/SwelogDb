using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOperationDtl
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string? OperationDesc { get; set; }

    public int? OperationDescTxtid { get; set; }

    public string? OperationDescFlag { get; set; }

    public string? ChildOperationList { get; set; }

    public string? ResourceNumber { get; set; }

    public string? RequiredSkillLevel { get; set; }

    public string? RequiredQualificationLevel { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public decimal? PieceWorkRate { get; set; }

    public decimal? TimeWorkRate { get; set; }

    public string? UnitOfWork { get; set; }

    public decimal? TimeRateFixedPart { get; set; }

    public decimal? OperationSetUpTime { get; set; }

    public decimal? ResourceSetUpTime { get; set; }

    public decimal? OperationCostingPrice { get; set; }

    public decimal? OperationSetupCost { get; set; }

    public decimal? OperationTime { get; set; }

    public decimal? ResourceTime { get; set; }

    public decimal? TurnAroundTime { get; set; }

    public string? WageType { get; set; }

    public short? NumberOfWorkTicket { get; set; }

    public DateTime? OperationLastChangeDate { get; set; }

    public string? ToolFlag { get; set; }

    public string? InspectionFlag { get; set; }

    public string? MeasurementFlag { get; set; }

    public string? CncProgramFlag { get; set; }

    public DateTime? MfgOperationStartTime { get; set; }

    public DateTime? MfgOperationEndTime { get; set; }

    public decimal? OperationReportQty { get; set; }

    public decimal? RejectionQty { get; set; }

    public decimal? ReportedTimeOfCompletion { get; set; }

    public string? ResTimeCalculationCode { get; set; }

    public string? TurnAroundTimeCalCode { get; set; }

    public int? MfgOrderSerialKey { get; set; }

    public string? AuditStamp { get; set; }

    public int? UnitConversionFactor { get; set; }

    public string? PriceIndex { get; set; }

    public string? PrintedFlag { get; set; }

    public string? ManuallyPlanned { get; set; }

    public string? OperationStatus { get; set; }

    public string? WorkTicketPrintFlag { get; set; }

    public string? ControlTicketPrintFlag { get; set; }

    public string? MeasurementProtPrintFlag { get; set; }

    public string? ToolRequisitionPrintFlag { get; set; }

    public string? MaterialRequisitionPrintFlag { get; set; }

    public string? CutlistPrintFlag { get; set; }

    public int? ResourceUnit { get; set; }

    public int? Milestone { get; set; }

    public string? OperationType { get; set; }

    public string? ExtraOperationFlag { get; set; }

    public string? ComponentSortStore { get; set; }

    public string? ErrorReportId { get; set; }

    public int? OperatorNumber { get; set; }

    public string? PalletConfirmationFlag { get; set; }

    public string? OperationShift { get; set; }

    public byte? OrdersPerShift { get; set; }

    public string? PlanningMethod { get; set; }

    public string? GenerateVinNumber { get; set; }

    public DateTime? MfgOprOrigEndDate { get; set; }

    public string? AdvDocPrinted { get; set; }

    public DateTime? ActualFinishDate { get; set; }

    public decimal? QtyPerPallet { get; set; }

    public string? PackingItemNumber { get; set; }

    public string? StoreLocation { get; set; }

    public string? OperationDocumentPrintFlag { get; set; }

    public string? OperationPicturePrintFlag { get; set; }

    public string? OperationDrawingPrintFlag { get; set; }

    public string? MfgOrderLine { get; set; }

    public int? GateNumber { get; set; }

    public int? ConnectingProjectOpNo { get; set; }

    public string? ExecutionResourceNumber { get; set; }

    public string? OperationComment { get; set; }

    public virtual MfgOperationListHdr MfgOperationListHdr { get; set; } = null!;
}
