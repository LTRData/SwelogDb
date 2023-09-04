using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOrderHdr
{
    public string MfgOrderNumber { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? OrderNumber2 { get; set; }

    public string? AuditStamp { get; set; }

    public short? MfgOrderType { get; set; }

    public string? MfgOrderText { get; set; }

    public string? TopItem { get; set; }

    public string? Tools { get; set; }

    public short? SpecialOrderSerial { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? ControlId { get; set; }

    public string? ProjectNo { get; set; }

    public virtual ICollection<MfgOrderDtl> MfgOrderDtls { get; } = new List<MfgOrderDtl>();
}
