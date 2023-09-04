using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArrivalInspectionPalletNotApprove
{
    public string InspectionId { get; set; } = null!;

    public short InspectionSerial { get; set; }

    public string PalletNo { get; set; } = null!;

    public string NotApproveCode { get; set; } = null!;

    public decimal? QtyNotApproved { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ArrivalInspectionPallet ArrivalInspectionPallet { get; set; } = null!;
}
