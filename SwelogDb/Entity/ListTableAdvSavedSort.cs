using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ListTableAdvSavedSort
{
    public int SerialNumber { get; set; }

    public int? HeaderSerialNumber { get; set; }

    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public string? AscDesc { get; set; }
}
