﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ListTableAdvSort
{
    public int SerialNumber { get; set; }

    public string? Userid { get; set; }

    public string? SearchIdentifier { get; set; }

    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public string? AscDesc { get; set; }
}
