using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Color
{
    public string ColorCode { get; set; } = null!;

    public string ColorDescription { get; set; } = null!;

    public int RgbValue { get; set; }

    public string? AuditStamp { get; set; }

    public int? SortOrder { get; set; }

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
