using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogSysdefault
{
    public int Id { get; set; }

    public string DefaultName { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string? ColumnName { get; set; }
}
