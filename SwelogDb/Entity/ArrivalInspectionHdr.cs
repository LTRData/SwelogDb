using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArrivalInspectionHdr
{
    public string InspectionId { get; set; } = null!;

    public short InspectionSerial { get; set; }

    public decimal? InspectedQty { get; set; }

    public decimal? ApprovedQty { get; set; }

    public string? CertificateDesc { get; set; }

    public string? InspectorReference { get; set; }

    public string? FinalComment { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public DateTime? InspectionDate { get; set; }

    public string? InspectionStatus { get; set; }

    public string? AuditStamp { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? RejectedQty { get; set; }

    public string? RejPalletNo { get; set; }

    public DateTime? ProcessDatetime { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? ApprovedCode { get; set; }

    public string? ReinspectionYn { get; set; }

    public string? ControlId { get; set; }

    public string? RecType { get; set; }

    public DateTime? ProductionDate { get; set; }

    public decimal? DevApprovedQty { get; set; }

    public string? DevApprovedComment { get; set; }

    public virtual ICollection<ArrivalInspectionOperation> ArrivalInspectionOperations { get; } = new List<ArrivalInspectionOperation>();

    public virtual ICollection<ArrivalInspectionPallet> ArrivalInspectionPallets { get; } = new List<ArrivalInspectionPallet>();

    public virtual ICollection<ArrivalRejectionHdr> ArrivalRejectionHdrs { get; } = new List<ArrivalRejectionHdr>();
}
