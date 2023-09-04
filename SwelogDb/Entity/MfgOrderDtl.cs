using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOrderDtl
{
    public string MfgOrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public decimal? OrderedQuantity { get; set; }

    public DateTime? MfgOrderStartDate { get; set; }

    public DateTime? MfgOrderFinishDate { get; set; }

    public decimal? DeliveryQuantity { get; set; }

    public string? MfgOrderStatus { get; set; }

    public decimal? QuantityPerPallet { get; set; }

    public short? NumberOfLabel { get; set; }

    public string? MfgOrderText { get; set; }

    public int? MfgOrderTextTxtid { get; set; }

    public string? JobOrderSetOption { get; set; }

    public string? Structure { get; set; }

    public string? AuditStamp { get; set; }

    public string? FrozenFlag { get; set; }

    public string? DrawingNo { get; set; }

    public string? RevisionNo { get; set; }

    public string? CopyItemNumber { get; set; }

    public int? CopyLotNumber { get; set; }

    public string? OplistChangedFlag { get; set; }

    public string? MaterialCheckFlag { get; set; }

    public string? BatchCreated { get; set; }

    public string? AssetType { get; set; }

    public string? ProductionCase { get; set; }

    public string? AssetProductionSpecification { get; set; }

    public string? DeviationFlag { get; set; }

    public int? DeviationTxtid { get; set; }

    public int? DeviationRepBy { get; set; }

    public DateTime? DeviationRepDate { get; set; }

    public DateTime? DeviationReviewDate { get; set; }

    public DateTime? CombinedReq { get; set; }

    public string? ErrorReportId { get; set; }

    public string? ComponentSortPositionwise { get; set; }

    public decimal? RejectedReworkedQty { get; set; }

    public DateTime? ActualStartDate { get; set; }

    public DateTime? ActualFinishDate { get; set; }

    public string? ToolNumber { get; set; }

    public string? GoodsMarking { get; set; }

    public string? ReworkPalletQtyList { get; set; }

    public int? IdToolCavityHeader { get; set; }

    public string? CustomerSelet { get; set; }

    public string? CustomerId { get; set; }

    public string? ItemDescription { get; set; }

    public decimal? DeviationQuantity { get; set; }

    public decimal? DeviationReviewQuantity { get; set; }

    public decimal? AllocatedNcQuantity { get; set; }

    public int? IdCascadeReservation { get; set; }

    public DateTime? MfgOrderOrigFinishDate { get; set; }

    public string? ReworkFlag { get; set; }

    public int? ParentOperationNumber { get; set; }

    public int? ParentLotNumber { get; set; }

    public string? MfgOrderLine { get; set; }

    public int? ColorCode { get; set; }

    public string? VinNumber { get; set; }

    public string? LabelLanguageCode { get; set; }

    public string? DataLanguageCode { get; set; }

    public string? HideInDispatchListYn { get; set; }

    public int? CascadeLevel { get; set; }

    public string? EcnNumber { get; set; }

    public decimal? OriginalOrderQuantity { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public virtual MfgOrderHdr MfgOrderNumberNavigation { get; set; } = null!;

    public virtual ICollection<MfgOrderSpecialItem> MfgOrderSpecialItems { get; } = new List<MfgOrderSpecialItem>();
}
