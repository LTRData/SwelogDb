using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbItemAttribute
{
    public string ItemNumber { get; set; } = null!;

    public string? SnapRingQuality { get; set; }

    public decimal? SnapRingDiameter { get; set; }

    public int? SnapRingSheetThickness { get; set; }

    public string? SnapRingYarnQuality { get; set; }

    public string? DustSide { get; set; }

    public string? Banner { get; set; }

    public bool? NeutralPacking { get; set; }

    public bool? PackedInCarton { get; set; }

    public bool? PackedInBag { get; set; }

    public string? FreeText { get; set; }

    public string? PreparationComments { get; set; }

    public string? CuttingDimension { get; set; }

    public int? SpecOperationTime { get; set; }

    public string? TemplateOperationListId { get; set; }

    public int? ProfitPercent { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int? SellingPrice { get; set; }
}
