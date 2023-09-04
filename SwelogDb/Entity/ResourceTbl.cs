using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceTbl
{
    public string ResourceNo { get; set; } = null!;

    public string? ResourceDescription { get; set; }

    public int? ResourceNameTxtid { get; set; }

    public string? ResourceNameFlag { get; set; }

    public string? ResourceType { get; set; }

    public short? NumberOfResourceUnits { get; set; }

    public decimal? ResourceRate { get; set; }

    public decimal? OverheadPercentage { get; set; }

    public decimal? AverageHourlyEarning { get; set; }

    public short? NumberOfShifts { get; set; }

    public decimal? Manning { get; set; }

    public decimal? MarkUp { get; set; }

    public decimal? UtilisationDegree { get; set; }

    public string? CostCentre { get; set; }

    public decimal? ResourceQueueTime { get; set; }

    public decimal? TimeRateFixedPart { get; set; }

    public decimal? HourlyDebitPriceOut { get; set; }

    public string? AuditStamp { get; set; }

    public int? ResourceColor { get; set; }

    public string? WithoutOperator { get; set; }

    public decimal? Efficiency { get; set; }

    public int? InactiveFlag { get; set; }

    public decimal? ResourceOverlap { get; set; }

    public string? CapacityCode { get; set; }

    public string? CompanyNo { get; set; }

    public int? Position { get; set; }

    public byte? HoursPerShift { get; set; }

    public string? ResourceType2 { get; set; }

    public string? MaintenanceFlag { get; set; }

    public string? SupplierId { get; set; }

    public string? SuppliersStoreLocation { get; set; }

    public string? EqplanTransferYn { get; set; }

    public string? InterruptCodeRequired { get; set; }

    public decimal? FinancialCost { get; set; }

    public decimal? DepresCost { get; set; }

    public decimal? ReobtainaddCost { get; set; }

    public bool? DontAllowTimeReporting { get; set; }

    public virtual ICollection<ChangeOperationDtl> ChangeOperationDtls { get; } = new List<ChangeOperationDtl>();

    public virtual ICollection<InspectionOperDtl> InspectionOperDtls { get; } = new List<InspectionOperDtl>();

    public virtual ICollection<OperationDtl> OperationDtls { get; } = new List<OperationDtl>();

    public virtual ResourceType? ResourceTypeNavigation { get; set; }

    public virtual ICollection<WorkProgress> WorkProgresses { get; } = new List<WorkProgress>();
}
