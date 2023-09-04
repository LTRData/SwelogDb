using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosPlannedOperDetail
{
    public string OperationList { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public string? ResourceNumber { get; set; }

    public string? WorkCenter { get; set; }

    public short? TurnAroundTime { get; set; }

    public decimal? WaitingTime { get; set; }

    public DateTime? OperationStartDay { get; set; }

    public DateTime? OperationReadyDay { get; set; }
}
