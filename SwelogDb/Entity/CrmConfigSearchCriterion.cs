using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmConfigSearchCriterion
{
    public int SerialNumber { get; set; }

    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public string? ColumnLabel { get; set; }

    public short? SortOrder { get; set; }
}
