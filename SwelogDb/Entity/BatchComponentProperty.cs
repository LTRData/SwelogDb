using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BatchComponentProperty
{
    public string ComponentItemNumber { get; set; } = null!;

    public string ComponentRevisionNumber { get; set; } = null!;

    public decimal? ComponentLength { get; set; }

    public decimal? ComponentBreadth { get; set; }

    public decimal? ComponentWidth { get; set; }

    public decimal? LeftEdge { get; set; }

    public decimal? RightEdge { get; set; }

    public string? ProfileNameLeftEdge { get; set; }

    public string? ProfileNameRightEdge { get; set; }

    public string? ProfileNameLeftLength { get; set; }

    public string? ProfileNameRightLength { get; set; }

    public string? ProgramId { get; set; }

    public string? ComponentAdjustment { get; set; }

    public string? ComponentRim { get; set; }
}
