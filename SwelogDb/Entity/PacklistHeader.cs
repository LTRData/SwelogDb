using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PacklistHeader
{
    public string PacklistNumber { get; set; } = null!;

    public string? PartnerId { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? PicklistNumber { get; set; }

    public string? PrintoutNumber { get; set; }

    public string? DeliveryNote { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? EdiFilePrinted { get; set; }

    public string? Status { get; set; }

    public string? AuditStamp { get; set; }

    public string? ActualContainerId { get; set; }

    public string? ContainerType { get; set; }

    public decimal? CapacityWeight { get; set; }

    public string? WeightUom { get; set; }

    public decimal? CapacityVolume { get; set; }

    public string? VolumeUom { get; set; }

    public DateTime? ActualDeliveryDate { get; set; }

    public string? SigilNumber { get; set; }

    public string? PegFlag { get; set; }

    public string? DespatcherPlace { get; set; }

    public string? PacklistType { get; set; }

    public string? YourDeliveryNote { get; set; }

    public string? BookingNo { get; set; }

    public decimal? TotDelQty { get; set; }

    public string? ViaLeverans { get; set; }

    public virtual ICollection<PackingItemsForDelivery> PackingItemsForDeliveries { get; } = new List<PackingItemsForDelivery>();

    public virtual ICollection<PackingItemsForDeliveryReport> PackingItemsForDeliveryReports { get; } = new List<PackingItemsForDeliveryReport>();

    public virtual ICollection<PackingStructureHdr> PackingStructureHdrs { get; } = new List<PackingStructureHdr>();

    public virtual ICollection<PacklistDetail> PacklistDetails { get; } = new List<PacklistDetail>();

    public virtual ICollection<PalletCoOrder> PalletCoOrders { get; } = new List<PalletCoOrder>();

    public virtual Customer? Partner { get; set; }
}
