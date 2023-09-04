using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolFmea
{
    public int SerialNumber { get; set; }

    public string ProjectNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string MeasurePoint { get; set; } = null!;

    public decimal? Dimension { get; set; }

    public string? Property { get; set; }

    public decimal? ToleranceLower { get; set; }

    public decimal? ToleranceUpper { get; set; }

    public string? PotentialFailureMode { get; set; }

    public string? PotentialFailureEffects { get; set; }

    public int? SevValue { get; set; }

    public string? Class { get; set; }

    public string? PotentialCauses { get; set; }

    public int? OccValue { get; set; }

    public string? CurrentControls { get; set; }

    public int? DetValue { get; set; }

    public int? RpnValue { get; set; }

    public string? RecommendedAction { get; set; }

    public string? RespTargetCompDate { get; set; }

    public string? ActionTaken { get; set; }

    public int? SevResult { get; set; }

    public int? OccResult { get; set; }

    public int? DetResult { get; set; }

    public int? RpnResult { get; set; }

    public string? Comments { get; set; }

    public int? RecommendedActionTxtid { get; set; }

    public int? ActionTakenTxtid { get; set; }

    public int? CommentsTxtid { get; set; }

    public int? PropertyTxtid { get; set; }

    public DateTime? CompletedDate { get; set; }

    public int? ShowInWhiteBook { get; set; }

    public string? ProjectItemNumber { get; set; }

    public string? RevisionNo { get; set; }

    public int? PfmeaId { get; set; }
}
