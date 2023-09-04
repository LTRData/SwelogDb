using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArrivalInspectionOperationTextCheck
{
    public string Goodsentry { get; set; } = null!;

    public short InspectionId { get; set; }

    public short Operation { get; set; }

    public string ControlTextCode { get; set; } = null!;

    public string? ControlDescription { get; set; }

    public byte[]? LongTextObject { get; set; }

    public string? ApprovedYn { get; set; }

    public string? Comment { get; set; }

    public string? AuditStamp { get; set; }
}
