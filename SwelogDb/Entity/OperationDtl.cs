using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperationDtl
{
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

    public int? UnitConversionFactor { get; set; }

    public string? PriceIndex { get; set; }

    public string? ManuallyPlanned { get; set; }

    public string? ContractYear { get; set; }

    public string? Period { get; set; }

    public int? OperatorNumber { get; set; }

    public string? PalletConfirmationFlag { get; set; }

    public string? PlanningMethod { get; set; }

    public string? OperationShift { get; set; }

    public byte? OrdersPerShift { get; set; }

    public string? GenerateVinNumber { get; set; }

    public string? NewDocumentsYn { get; set; }

    public short? CascadeOperationNumber { get; set; }

    public int? QuantityLimitToInspection { get; set; }

    public int? AccQuantityAtLatestInspection { get; set; }

    public decimal? QtyPerPallet { get; set; }

    public string? PackingItemNumber { get; set; }

    public string? StoreLocation { get; set; }

    public int? ConsumeAutoReworkOperationNumber { get; set; }

    public string? AutoReworkOperationList { get; set; }

    public decimal? SpeccostPurchoprfreightEu { get; set; }

    public decimal? SpeccostPurchoprfreightSv { get; set; }

    public decimal? QtyPerOperation { get; set; }

    public int? LengthMargin { get; set; }

    public int? BreadthMargin { get; set; }

    public decimal? SpeccostRework { get; set; }

    public decimal? SpeccostRejection { get; set; }

    public decimal? SpeccostToolservice { get; set; }

    public decimal? CostPriceExchangeRate { get; set; }

    public string? CostPriceExchangeCurrency { get; set; }

    public decimal? TotaccumComponentCost { get; set; }

    public decimal? TotaccumWagecost { get; set; }

    public decimal? TotaccumOther { get; set; }

    public decimal? TotaccumAlloyCost { get; set; }

    public int? GateNumber { get; set; }

    public int? ConnectingProjectOpNo { get; set; }

    public virtual ChangeManufacturingInspectionHdr? ChangeManufacturingInspectionHdr { get; set; }

    public virtual OperationListHdr? ChildOperationListNavigation { get; set; }

    public virtual EcoMfgInspectionHdr? EcoMfgInspectionHdr { get; set; }

    public virtual ICollection<ItemSupplierOpr> ItemSupplierOprs { get; } = new List<ItemSupplierOpr>();

    public virtual OperationListHdr OperationListNavigation { get; set; } = null!;

    public virtual QualificationLevel? RequiredQualificationLevelNavigation { get; set; }

    public virtual SkillLevel? RequiredSkillLevelNavigation { get; set; }

    public virtual ResourceTbl? ResourceNumberNavigation { get; set; }

    public virtual UnitOfMeasure? UnitOfWorkNavigation { get; set; }
}
