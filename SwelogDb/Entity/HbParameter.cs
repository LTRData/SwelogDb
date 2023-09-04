using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbParameter
{
    public int Id { get; set; }

    public short MarginOuterSheetFrame { get; set; }

    public short MarginInnerSheetFrame { get; set; }

    public short ReductionInnerSheetFrame { get; set; }

    public short ReductionPlasticProfile { get; set; }

    public short ReductionPlasticStick { get; set; }

    public string ProductGroupPocket { get; set; } = null!;

    public int OperationNumberPacking { get; set; }

    public string? TemplateFilterItemNumber { get; set; }

    public string? MoldingItemNumber { get; set; }

    public string? PackingItemNumber { get; set; }

    public string? PlasticCornerItemNumber { get; set; }

    public string? ItemDiscountGroupCodeStd { get; set; }

    public string? ItemDiscountGroupCodeSpl { get; set; }

    public string? ProductGroupFilter { get; set; }

    public string? ProductGroupTube { get; set; }

    public string? ProductGroupTubeMaterial { get; set; }

    public string? TemplateTubeItemNumber { get; set; }

    public int? TubeMaterialWastagePercentage { get; set; }

    public string? ProductGroupTubeYarn { get; set; }

    public short? LongSeamCount { get; set; }

    public decimal? LongSeamFactor { get; set; }

    public short? LongSeamMargin { get; set; }

    public short? CrossSeamCount { get; set; }

    public decimal? CrossSeamFactor { get; set; }

    public short? CrossSeamMargin { get; set; }

    public string? SpecialOperationListId { get; set; }

    public string? SnapRingSmallItemNumber { get; set; }

    public string? SnapRingBigItemNumber { get; set; }

    public short? SnapRingStdHeight { get; set; }

    public short? SnapRingDwHeight { get; set; }

    public string? ProductGroupPanel { get; set; }

    public string? ProductGroupRollPad { get; set; }

    public string? ProductGroupSupportRing { get; set; }

    public string? SupportRingSmallItemNumber { get; set; }

    public string? SupportRingMediumItemNumber { get; set; }

    public string? SupportRingBigItemNumber { get; set; }

    public string? ProductGroupDwBand { get; set; }

    public string? ProductGroupWetFilter { get; set; }

    public string? StitchingOperations { get; set; }

    public string? WeldingOperations { get; set; }

    public string? DcePackWeldItemNumber { get; set; }

    public string? DcePackStitchItemNumber { get; set; }

    public short? MarginPocketDivision { get; set; }

    public decimal? MarginPocketBreadth { get; set; }

    public decimal? MarginPocketDepth { get; set; }

    public string? ProductGroupFeltWasher { get; set; }

    public string? FeltWasherOperations { get; set; }
}
