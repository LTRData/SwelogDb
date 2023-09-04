using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PackingStructureDtl
{
    public string PacklistNumber { get; set; } = null!;

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string PalletNumber { get; set; } = null!;

    public string SmallboxNumber { get; set; } = null!;

    public string? SmallboxName { get; set; }

    public string? PackingType { get; set; }

    public int? QtyPerSmallbox { get; set; }

    public decimal? ItemWeight { get; set; }

    public decimal? NetItemWeight { get; set; }

    public decimal? SmallboxWeight { get; set; }

    public decimal? NetSmallboxWeight { get; set; }

    public string? PackingStructureId { get; set; }

    public string? SmallboxDescription { get; set; }

    public decimal? VolumeOfSmallbox { get; set; }

    public string? AuditStamp { get; set; }

    public string? FileCreated { get; set; }

    public short? PicklistDtlLineNo { get; set; }

    public string? PalletNo { get; set; }

    public string? CcPalletNo { get; set; }

    public string? PalletArrived { get; set; }

    public virtual PackingStructureHdr PackingStructureHdr { get; set; } = null!;
}
