using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempMfgClearanceNotFinished
{
    public string MfgOrderNumber { get; set; } = null!;

    public string? Description { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public DateTime? MfgOrderStartDate { get; set; }

    public DateTime? MfgOrderFinishDate { get; set; }

    public string? MfgOrderStatus { get; set; }

    public string? DeleteRow { get; set; }
}
