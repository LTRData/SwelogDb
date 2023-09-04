using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactPsOperatorDirectTime
{
    public int IdPsOperatorDirectTime { get; set; }

    public int EmployeeNumber { get; set; }

    public DateTime FromDateTime { get; set; }

    public DateTime UptoDateTime { get; set; }

    public string? ActivityNo { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public int SequenceNo { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public int OperationNumber { get; set; }

    public string? ProductionGroupId { get; set; }

    public decimal? QtyProduced { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public DateTime? MpcStartDate { get; set; }

    public DateTime? MpcEndDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? ActivityType { get; set; }

    public decimal? PlannedTime { get; set; }
}
