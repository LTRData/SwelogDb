using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpPiReportsDetail
{
    public int ProcessId { get; set; }

    public int TransactionId { get; set; }

    public int SerialId { get; set; }

    public string? ProductionGroupId { get; set; }

    public string? ResourceNumber { get; set; }

    public string? ResourceDescription { get; set; }

    public string? ActivityType { get; set; }

    public string? ActivityNo { get; set; }

    public string? ActivityDescription { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public string? ItemDescription { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? ReportDateTime { get; set; }

    public int? ReportedBy { get; set; }

    public decimal? QtyProduced { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public string? FinishedFlag { get; set; }

    public decimal? ProductionTime { get; set; }

    public decimal? SetupTime { get; set; }

    public string? QtyFormat { get; set; }

    public int? EmployeeNo { get; set; }

    public string? EmployeeName { get; set; }
}
