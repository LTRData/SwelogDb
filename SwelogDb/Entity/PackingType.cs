using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PackingType
{
    public string CustomerId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string PackingCode { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public string? DangerCode { get; set; }

    public string? PackingSizeCode { get; set; }

    public decimal? QuantityPerPacket { get; set; }

    public decimal? QuantityPerStool { get; set; }

    public decimal? WeightPerPacket { get; set; }

    public decimal? WeightPerStool { get; set; }

    public string? PackagingInstructionCode { get; set; }

    public string? PackingMaterialStructure { get; set; }

    public string? SafetyIndicator { get; set; }

    public string? ItemOriginCode { get; set; }

    public string? DespatchLoadingPoint { get; set; }

    public short? PackingTimeMargin { get; set; }

    public string? AuditStamp { get; set; }

    public string? TechStat1 { get; set; }

    public DateTime? FromDate1 { get; set; }

    public string? TechStat2 { get; set; }

    public DateTime? FromDate2 { get; set; }

    public decimal? CumulativeDelivery { get; set; }

    public DateTime? LastDeliveryDate { get; set; }

    public decimal? CumulativeReceipt { get; set; }

    public DateTime? LastReceiptDate { get; set; }

    public string? AutoDeduct { get; set; }

    public virtual Item ItemNumberNavigation { get; set; } = null!;
}
