using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdItemType
{
    public string ItemType { get; set; } = null!;

    public string? TemplateItemNumber { get; set; }

    public string? NumberRangeSeries { get; set; }

    public string? ItemTypeDescription { get; set; }

    public string? StructItemNumberFrame { get; set; }

    public string? StructItemNumberLeaf { get; set; }

    public string? ProductGroupFrame { get; set; }

    public string? ProductGroupThreshold { get; set; }

    public string? ProductGroupCompleteItem { get; set; }

    public string? ProductGroupFrameItem { get; set; }

    public short? FrameThickness { get; set; }

    public short? LintelThickness { get; set; }

    public string? StructItemNumberGeneral { get; set; }

    public string? StructItemNumberFrame64 { get; set; }
}
