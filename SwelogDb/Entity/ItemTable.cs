using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemTable
{
    public string ItemNumber { get; set; } = null!;

    public string ItemDescription { get; set; } = null!;

    public string ItemType { get; set; } = null!;
}
