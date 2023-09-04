using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SystemItem
{
    public string SystemItemCode { get; set; } = null!;

    public string? ItemNumber { get; set; }
}
