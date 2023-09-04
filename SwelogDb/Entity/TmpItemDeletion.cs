using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpItemDeletion
{
    public short ProcessId { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public byte? StructureExists { get; set; }

    public byte? BalanceExists { get; set; }

    public byte? ReservationExists { get; set; }

    public byte? PoExists { get; set; }

    public byte? MoExists { get; set; }

    public byte? InspectionExists { get; set; }

    public byte? OkToDelete { get; set; }

    public byte? DeletedFlag { get; set; }

    public short? CoExists { get; set; }
}
