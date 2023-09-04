using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArrivalInspectionOperation
{
    public string InspectionId { get; set; } = null!;

    public short InspectionSerial { get; set; }

    public short OperationNumber { get; set; }

    public decimal? InspectedQty { get; set; }

    public decimal? ApprovedQty { get; set; }

    public string? CertificateDesc { get; set; }

    public string? InspectorReference { get; set; }

    public string? FinalComment { get; set; }

    public string? AuditStamp { get; set; }

    public string? InspectionStatus { get; set; }

    public decimal? RejectedQty { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? GenerelTextComment { get; set; }

    public string? GenerelTextCheckedYn { get; set; }

    public string? GenerelTextOkYn { get; set; }

    public string? ControlTextComment { get; set; }

    public DateTime? InspectionDate { get; set; }

    public virtual ICollection<ArrivalInspectionDtl> ArrivalInspectionDtls { get; } = new List<ArrivalInspectionDtl>();

    public virtual ArrivalInspectionHdr Inspection { get; set; } = null!;
}
