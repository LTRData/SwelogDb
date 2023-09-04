using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AbcTable
{
    public string ItemNo { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? ItemType { get; set; }

    public string? AbcCode { get; set; }

    public DateTime LastUpdationDate { get; set; }

    public string? LastAbcCriteria { get; set; }
}
