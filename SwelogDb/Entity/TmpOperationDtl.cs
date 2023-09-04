using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpOperationDtl
{
    public int ProcessId { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public string OperationList { get; set; } = null!;

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

    public string? AuditStamp { get; set; }

    public short? UnitConversionFactor { get; set; }

    public string? PriceIndex { get; set; }

    public string? ManuallyPlanned { get; set; }
}
