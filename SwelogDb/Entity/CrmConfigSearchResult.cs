using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmConfigSearchResult
{
    public int SerialNumber { get; set; }

    public string? UserId { get; set; }

    public string? ColumnName { get; set; }

    public string? ColumnLabel { get; set; }

    public short? SortOrder { get; set; }
}
