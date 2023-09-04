using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductionGroup
{
    public string ProductionGroupId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? GroupDescription { get; set; }

    public int? GroupDescTxtid { get; set; }

    public string? GroupDescFlag { get; set; }

    public string? TimeShareCode { get; set; }

    public string? WageTransOption { get; set; }

    public string? PieceWorkTypeCode { get; set; }

    public string? WageType { get; set; }

    public string? CostCentre { get; set; }

    public string? OperatorOption { get; set; }

    public string? AuditStamp { get; set; }

    public string? ProductionGroupType { get; set; }

    public string? PlannedResourceCost { get; set; }

    public string? GroupWorkOption { get; set; }

    public string? PayIndirectActivity { get; set; }

    public string? ClosedFlag { get; set; }

    public string? RepWhenLeaving { get; set; }

    public string? ReportJobsFromOtherGroups { get; set; }

    public string? DeviationPerPallet { get; set; }

    public decimal? UtilisationDegree { get; set; }

    public string? AutoChangeOfWorkplaceYn { get; set; }

    public string? CncProgramFlag { get; set; }

    public string? ComponentOnDispatchListYn { get; set; }
}
