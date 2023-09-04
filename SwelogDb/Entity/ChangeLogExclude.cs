using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeLogExclude
{
    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;
}
