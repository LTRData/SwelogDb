using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProjectToolDetail
{
    public string ProjectNumber { get; set; } = null!;

    public string ToolNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? ConstructorId { get; set; }

    public string? BandWidth { get; set; }

    public string? FeedingLength { get; set; }

    public string? Thickness { get; set; }

    public DateTime? ConstructionEndDate { get; set; }

    public DateTime? ProductionEndDate { get; set; }

    public string? ProjectType { get; set; }

    public string? PrelBandWidth { get; set; }

    public string? PrelFeedingLength { get; set; }

    public string? PrelThickness { get; set; }
}
