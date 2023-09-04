using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArrivalInspectionPallet
{
    public string InspectionId { get; set; } = null!;

    public short InspectionSerial { get; set; }

    public string? ItemNumber { get; set; }

    public string PalletNo { get; set; } = null!;

    public decimal? InspectedQty { get; set; }

    public decimal? QtyNotApproved { get; set; }

    public string? StoreLocation { get; set; }

    public string? StockPosition { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? DevApprovedQty { get; set; }

    public virtual ICollection<ArrivalInspectionPalletNotApprove> ArrivalInspectionPalletNotApproves { get; } = new List<ArrivalInspectionPalletNotApprove>();

    public virtual ArrivalInspectionHdr Inspection { get; set; } = null!;
}
