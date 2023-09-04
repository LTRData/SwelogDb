using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolHeader
{
    public string ToolNumber { get; set; } = null!;

    public string? ToolDescription { get; set; }

    public int? ToolDescriptionTxtid { get; set; }

    public string? ToolDescriptionFlag { get; set; }

    public string? ToolType { get; set; }

    public int? NumberOfTool { get; set; }

    public string? ItemNumber { get; set; }

    public string? DrawingNumber { get; set; }

    public string? RevisionNumber { get; set; }

    public decimal? ToolStrokeLength { get; set; }

    public decimal? QuantityPerStroke { get; set; }

    public decimal? ToolStrokePerMinute { get; set; }

    public int? ToolPressure { get; set; }

    public string? AuditStamp { get; set; }

    public string? ItemType1 { get; set; }

    public DateTime? ValidForProductionFrom { get; set; }

    public bool? Reconstructable { get; set; }

    public virtual ICollection<ChangeInspectionTool> ChangeInspectionTools { get; } = new List<ChangeInspectionTool>();

    public virtual ICollection<ChangeOperationTool> ChangeOperationTools { get; } = new List<ChangeOperationTool>();

    public virtual ICollection<InspectionInspTool> InspectionInspTools { get; } = new List<InspectionInspTool>();

    public virtual ICollection<InspectionOperTool> InspectionOperTools { get; } = new List<InspectionOperTool>();

    public virtual ICollection<InspectionTool> InspectionTools { get; } = new List<InspectionTool>();

    public virtual Item? ItemNumberNavigation { get; set; }

    public virtual ICollection<OperationTool> OperationTools { get; } = new List<OperationTool>();

    public virtual ICollection<ToolDetail> ToolDetails { get; } = new List<ToolDetail>();

    public virtual ToolType? ToolTypeNavigation { get; set; }
}
