using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperatorDirectTimeDtl
{
    public string ResourceNumber { get; set; } = null!;

    public int EmployeeNumber { get; set; }

    public DateTime TrnDate { get; set; }

    public string? ActivityNo { get; set; }

    public DateTime ReportDateTime { get; set; }

    public int SequenceNo { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public int OperationNumber { get; set; }

    public DateTime? StartDateTime { get; set; }

    public string? ProductionGroupId { get; set; }

    public decimal? QtyProduced { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? SetupTime { get; set; }

    public int? NoOfSetup { get; set; }

    public string? FinalDelivery { get; set; }

    public DateTime? MpcStartDate { get; set; }

    public DateTime? MpcEndDate { get; set; }

    public short Year { get; set; }

    public short Week { get; set; }

    public short Day { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? OpStartDateTime { get; set; }

    public DateTime? OpEndDateTime { get; set; }

    public int IdOperatorDirectTimeDtl { get; set; }

    public DateTime? ShiftDate { get; set; }
}
