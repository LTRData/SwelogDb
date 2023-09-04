using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PiParameterDetail
{
    public string PiParameterId { get; set; } = null!;

    public string? ResourceNo { get; set; }

    public string? RepUnapprovedItem { get; set; }

    public string? CapPlanOnTerm { get; set; }

    public string? OnlyReleased { get; set; }

    public string? WithoutOperator { get; set; }

    public string? AuditStamp { get; set; }

    public string? RepSetup { get; set; }

    public string? RepWhenLeaving { get; set; }

    public decimal? LowAlarm { get; set; }

    public decimal? HighAlarm { get; set; }

    public string ProductionGroupId { get; set; } = null!;

    public short? DispatchLimit { get; set; }

    public string? ReservationFlag { get; set; }

    public int? ReservationLimit { get; set; }

    public int? ReservationPriority { get; set; }

    public string? IgnoreWithdrawalParameter { get; set; }

    public int? PlanningLimit { get; set; }

    public virtual PiParameterHeader PiParameter { get; set; } = null!;
}
