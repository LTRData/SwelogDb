using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OpenOrderDetail
{
    public int LotNumber { get; set; }

    public string ItemNumber { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string? ResourceNo { get; set; }

    public string? WorkCentre { get; set; }

    public short? TurnAroundTime { get; set; }

    public short? WaitingTime { get; set; }

    public DateTime? OperationStartDay { get; set; }

    public DateTime? OperationReadyDay { get; set; }

    public string? AuditStamp { get; set; }
}
