using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemPackingInstruction
{
    public string ItemNumber { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public string? PackingStructureId { get; set; }

    public decimal? AccumulatedDeliveredQty { get; set; }

    public DateTime? LatestDeliveryDate { get; set; }

    public decimal? AccumulatedReceivedQty { get; set; }

    public DateTime? LatestRcvdDeliveryDate { get; set; }

    public string? AutoDeductFlag { get; set; }

    public string? DocumentBoundedFlag { get; set; }

    public string? AccRcvdFromDelnoteFlag { get; set; }

    public string? OriginCode { get; set; }

    public string? DangerCode { get; set; }

    public decimal? AheadTime { get; set; }

    public string? DespatcherPlace { get; set; }

    public string? PackingInstruction { get; set; }

    public string? ResponsibleCode { get; set; }

    public string? PalletOptionFlag { get; set; }

    public string? LabelId { get; set; }

    public int? LongTextTxtid { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? CumBackOrderQty { get; set; }

    public string? KanbanIndicator { get; set; }

    public short? KanbanDays { get; set; }

    public short? DayAny { get; set; }

    public short? DayMonday { get; set; }

    public short? DayTuesday { get; set; }

    public short? DayWednesday { get; set; }

    public short? DayThursday { get; set; }

    public short? DayFriday { get; set; }

    public int? LastDelplanDbimportDtlId { get; set; }

    public string? DefaultForEstimateYn { get; set; }

    public string? CustPackingCode { get; set; }

    public string? UpdateCustPackingCodeInEdi { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Item ItemNumberNavigation { get; set; } = null!;
}
