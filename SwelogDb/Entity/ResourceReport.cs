using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceReport
{
    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public string ActivityNo { get; set; } = null!;

    public string ActivityType { get; set; } = null!;

    public string? ReportType { get; set; }

    public decimal? QtyProduced { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public int? ReportedBy { get; set; }

    public string? UpdateFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? FinalDelivery { get; set; }

    public int SequenceNo { get; set; }

    public string? PlannedResource { get; set; }

    public string? ProductionGroupType { get; set; }

    public DateTime? MpcUpdateDate { get; set; }

    public string? ProductionGroupId { get; set; }

    public DateTime? EndDateTime { get; set; }

    public int? AttestedBy { get; set; }

    public DateTime? AttestedDateTime { get; set; }

    public string? BonusFlag { get; set; }

    public int? CavityOperationSerialKey { get; set; }

    public string? HangerNumber { get; set; }

    public int? TextId { get; set; }

    public decimal? QtyWithdrawnMaterial { get; set; }

    public string? DivisionReportKey { get; set; }
}
