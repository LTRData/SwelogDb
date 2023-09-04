using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpProcessRejection
{
    public int IdTmpProcessRejection { get; set; }

    public DateTime ProcessDatetime { get; set; }

    public string? RejectionCode { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? EmployeeInspector { get; set; }

    public int RowId { get; set; }

    public string? RejectionCase { get; set; }

    public string? Location { get; set; }

    public string? Position { get; set; }

    public string? PalletNo { get; set; }

    public decimal? RejectionQty { get; set; }

    public string? RejectionTransactionCode { get; set; }

    public string? RefTranNo { get; set; }

    public string? RefTranId { get; set; }

    public string GoodsentryNo { get; set; } = null!;

    public int InspectionSerial { get; set; }

    public int InspectionOperation { get; set; }

    public string? ControlId { get; set; }

    public string? MeasurePoint { get; set; }

    public decimal? MeasuredValue { get; set; }

    public decimal? ToleranceLower { get; set; }

    public decimal? ToleranceUpper { get; set; }

    public string? ItemNumber { get; set; }

    public string? FinalDescription { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public string? PalletOwnerType { get; set; }

    public string? PalletOwner { get; set; }

    public string? PalletStatus { get; set; }

    public string? CertificateDesc { get; set; }

    public string? CertifacateLabel { get; set; }

    public string? AuditStamp { get; set; }

    public string? SkipStockhandlingYn { get; set; }

    public string? OrderLineType { get; set; }
}
