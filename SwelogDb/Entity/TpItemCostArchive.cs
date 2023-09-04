using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TpItemCostArchive
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public DateTime? ArchiveDate { get; set; }

    public string? ArchiveKey { get; set; }
}
