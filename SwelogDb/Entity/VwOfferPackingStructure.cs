using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwOfferPackingStructure
{
    public string? Item { get; set; }

    public string? PackingItem { get; set; }

    public string? PackingItemDescription { get; set; }

    public int? NumberPerPallet { get; set; }

    public string PackingComponentPart { get; set; } = null!;

    public decimal? PackingQuantityOfComponent { get; set; }

    public string? PackingComponentDescription { get; set; }

    public string? PackingComponentUnit { get; set; }

    public decimal? PackingComponentCost { get; set; }

    public string HasPackMtrlFlagYn { get; set; } = null!;

    public string HasPackMaterialFreeOfChargeYn { get; set; } = null!;

    public decimal? PalletFreightWeight { get; set; }

    public string? PackingStructureId { get; set; }
}
