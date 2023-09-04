using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempTableStructureItem
{
    public string? ParentItem { get; set; }

    public string? ComponentPart { get; set; }

    public int? OperationNumber { get; set; }

    public string? ComponentOperation { get; set; }
}
