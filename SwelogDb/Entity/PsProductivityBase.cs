using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PsProductivityBase
{
    public string? TrnType { get; set; }

    public string? ActivityNo { get; set; }

    public string? ActivityDescription { get; set; }

    public DateTime? ActivityDate { get; set; }

    public int? EmployeeNo { get; set; }

    public string? EmployeeName { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? ReportDateTime { get; set; }

    public decimal? DirectTime { get; set; }

    public decimal? IndirectTime { get; set; }

    public decimal? AttendanceTime { get; set; }

    public decimal? QtyProduced { get; set; }

    public string? ParentActivityNo { get; set; }

    public string? ResourceNumber { get; set; }

    public string? ProductionGroupId { get; set; }

    public int? SequenceNo { get; set; }

    public string? ModuleId { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public string? OperationDescription { get; set; }

    public decimal? QtyApproved { get; set; }

    public decimal? PlannedTime { get; set; }

    public decimal? NotApprovedPlannedTime { get; set; }

    public string? CostCenter { get; set; }

    public int? YearNo { get; set; }

    public int? WeekNo { get; set; }

    public decimal? IndTimeMachine { get; set; }

    public decimal? IndTimeTool { get; set; }

    public decimal? IndTimeNonProd { get; set; }

    public decimal? IndTimeOther { get; set; }

    public string? InterruptCode { get; set; }

    public string? InterruptDescription { get; set; }

    public string? TrnInd { get; set; }

    public string? CustomerId { get; set; }
}
