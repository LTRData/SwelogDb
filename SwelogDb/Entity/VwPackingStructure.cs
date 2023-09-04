using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwPackingStructure
{
    public string Item { get; set; } = null!;

    public string? PackingItem { get; set; }

    public string? PackingItemDescription { get; set; }

    public decimal? NumberPerPallet { get; set; }

    public string PackingComponentPart { get; set; } = null!;

    public decimal? PackingQuantityOfComponent { get; set; }

    public string? PackingComponentDescription { get; set; }

    public string? PackingComponentUnit { get; set; }

    public decimal? PackingComponentCost { get; set; }

    public string? HasPackMtrlFlagYn { get; set; }

    public string? HasPackMaterialFreeOfChargeYn { get; set; }

    public decimal? PalletFreightWeight { get; set; }

    public string PackingStructureId { get; set; } = null!;
}
