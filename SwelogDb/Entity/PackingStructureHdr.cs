using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PackingStructureHdr
{
    public string PacklistNumber { get; set; } = null!;

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string PalletNumber { get; set; } = null!;

    public string? PalletName { get; set; }

    public string? PackingType { get; set; }

    public string? PalletType { get; set; }

    public string? PackingInstruction { get; set; }

    public string? PackingStructureId { get; set; }

    public string? PalletDescription { get; set; }

    public int? QtyPerPallet { get; set; }

    public int? NumberOfPallets { get; set; }

    public int? QtyPerSmallbox { get; set; }

    public int? NumberOfSmallboxes { get; set; }

    public decimal? ItemWeight { get; set; }

    public decimal? NetItemWeight { get; set; }

    public decimal? SmallboxWeight { get; set; }

    public decimal? NetSmallboxWeight { get; set; }

    public decimal? WeightOfPallet { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? VolumeOfPallet { get; set; }

    public string? Status { get; set; }

    public string? MfgOrderNumber { get; set; }

    public DateTime? ProductionDate { get; set; }

    public string? CustomerOrderNo { get; set; }

    public string? ContractOrderNo { get; set; }

    public string? ItemRevisionNo { get; set; }

    public string? ItemStatisticsNumber { get; set; }

    public string? CustomerArticleIdentity { get; set; }

    public string? AuditStamp { get; set; }

    public string? FileCreated { get; set; }

    public short? PicklistDtlLineNo { get; set; }

    public string? PalletNo { get; set; }

    public string? CcPalletNo { get; set; }

    public string? PalletArrived { get; set; }

    public virtual ICollection<PackingStructureDtl> PackingStructureDtls { get; } = new List<PackingStructureDtl>();

    public virtual PacklistHeader PacklistNumberNavigation { get; set; } = null!;
}
