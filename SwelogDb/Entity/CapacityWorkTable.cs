using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CapacityWorkTable
{
    public int LotNumber { get; set; }

    public string ItemNumber { get; set; } = null!;

    public short BrowseActionNo { get; set; }

    public string? BrowseRecordType { get; set; }

    public string? RecordStructure { get; set; }

    public string? BrowseAction { get; set; }

    public string? AuditStamp { get; set; }
}
