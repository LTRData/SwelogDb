using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpProcessReceival
{
    public int IdTmpProcessReceival { get; set; }

    public DateTime ProcessDatetime { get; set; }

    public string? TransactionCode { get; set; }

    public string GoodsentryNo { get; set; } = null!;

    public string? RefTranNo { get; set; }

    public string? RefTranId { get; set; }

    public int RowId { get; set; }

    public int? TranSerial { get; set; }

    public int InspectionSerial { get; set; }

    public int InspectionOperation { get; set; }

    public string? Location { get; set; }

    public string? Position { get; set; }

    public string? PalletNo { get; set; }

    public decimal? ReceivalQty { get; set; }

    public string? FinalDelivery { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemType3 { get; set; }

    public string? InspectionYn { get; set; }

    public string? PalletHandlingYn { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public string? OrderLineType { get; set; }

    public string? SkipStockhandlingYn { get; set; }

    public string? PalletOwnerType { get; set; }

    public string? PalletOwner { get; set; }

    public string? PalletStatus { get; set; }

    public string? PalletOrderNo { get; set; }

    public string? PalletControlId { get; set; }

    public string? CertificateDesc { get; set; }

    public string? CertificateLabel { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? ArrivalDate { get; set; }
}
