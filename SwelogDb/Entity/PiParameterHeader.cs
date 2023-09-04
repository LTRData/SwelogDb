using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PiParameterHeader
{
    public string PiParameterId { get; set; } = null!;

    public string? RepUnapprovedItem { get; set; }

    public string? CapPlanOnTerm { get; set; }

    public string? OnlyReleased { get; set; }

    public string? WithoutOperator { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? MpcUpdationDate { get; set; }

    public string? DefaultProductionGroupId { get; set; }

    public string? DefaultProductionGroupName { get; set; }

    public DateTime? MpcSelectionDate { get; set; }

    public string? RepSetup { get; set; }

    public string? RepWhenLeaving { get; set; }

    public decimal? LowAlarm { get; set; }

    public decimal? HighAlarm { get; set; }

    public string? PlannedResourceCost { get; set; }

    public short? DispatchLimit { get; set; }

    public string? ReservationFlag { get; set; }

    public int? ReservationLimit { get; set; }

    public int? ReservationPriority { get; set; }

    public int? PurgeLimit { get; set; }

    public string? ReportJobsFromOtherGroups { get; set; }

    public string? DontAllowResChangeInPrep { get; set; }

    public string? DeviationPerPallet { get; set; }

    public string? CostCentre { get; set; }

    public decimal? UtilisationDegree { get; set; }

    public string? InhibitPiJticketPrintoutYn { get; set; }

    public int? DivActPartReportLimit { get; set; }

    public string? IgnoreWithdrawalParameter { get; set; }

    public int? PlanningLimit { get; set; }

    public string? DivisionActivityForCavityOperation { get; set; }

    public string? DefaultIndirectActivity { get; set; }

    public int? MpcSelectionMarginDays { get; set; }

    public short? ProductionStatisticsMarginDays { get; set; }

    public string? AutoChangeOfWorkplaceYn { get; set; }

    public int? AutoAnalysisLimit { get; set; }

    public string? ShowTimeInHoursMinutes { get; set; }

    public string? ShowOnlyShortageMaterial { get; set; }

    public string? IndirectActivityForAverageEarning { get; set; }

    public string? ProductionNotificationRecipient { get; set; }

    public string? AllowToolSerialSelectionYn { get; set; }

    public string? DeletePalletWithRemQtyBelowLimit { get; set; }

    public string? ToolNumberOnDispatchListYn { get; set; }

    public string? CalcTimeOnDispatchListYn { get; set; }

    public string? MoFinishDateOnDispatchListYn { get; set; }

    public string? OrderNumber2OnDispatchListYn { get; set; }

    public string? OperationCommentOnDispatchListYn { get; set; }

    public string? ComponentOnDispatchListYn { get; set; }

    public string? OrderTypeOnDispatchListYn { get; set; }

    public string? ToolCheckOnDispatchListYn { get; set; }

    public string? MaterialCheckOnDispatchListYn { get; set; }

    public string? RevisionNoOnDispatchListYn { get; set; }

    public string? RemainingTimeCalculationMethod { get; set; }

    public virtual ICollection<PiParameterDetail> PiParameterDetails { get; } = new List<PiParameterDetail>();
}
