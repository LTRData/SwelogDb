using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemPackingStructure
{
    public string ItemNumber { get; set; } = null!;

    public string PackingStructureId { get; set; } = null!;

    public string? PackingStructureDescription { get; set; }

    public int? StructureDescriptionTxtid { get; set; }

    public decimal? NumberPerSmallbox { get; set; }

    public decimal? NumberPerPallet { get; set; }

    public decimal? NetWtPerSmallbox { get; set; }

    public string? WtUomSmallbox { get; set; }

    public decimal? NetWtPerPallet { get; set; }

    public string? WtUomPallet { get; set; }

    public string? PackingCode { get; set; }

    public string? PalletType { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? VolSmallbox { get; set; }

    public string? VolUomSmallbox { get; set; }

    public decimal? VolPallet { get; set; }

    public string? VolUomPallet { get; set; }

    public string? PalletName { get; set; }

    public string? SmallboxName { get; set; }

    public string? SmallboxDbFlag { get; set; }
}
