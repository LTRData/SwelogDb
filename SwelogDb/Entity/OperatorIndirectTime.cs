using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperatorIndirectTime
{
    public string ActivityNo { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public int EmployeeNo { get; set; }

    public string? ActivityType { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? TimeWorkRate { get; set; }

    public decimal? Amount { get; set; }

    public string? ActivityDescription { get; set; }

    public string? DirectActivityNo { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public int SequenceNo { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public string? DirectActivityType { get; set; }

    public DateTime ActivityStart { get; set; }

    public int? ReportedBy { get; set; }

    public string? ProductionGroupId { get; set; }

    public DateTime? MpcStartDate { get; set; }

    public DateTime? MpcEndDate { get; set; }

    public decimal? OperatorTimeForBonus { get; set; }

    public string? InterruptCode { get; set; }
}
