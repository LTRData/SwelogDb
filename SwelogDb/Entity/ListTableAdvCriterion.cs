﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ListTableAdvCriterion
{
    public int SerialNumber { get; set; }

    public string? Userid { get; set; }

    public string? SearchIdentifier { get; set; }

    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public string? Datatype { get; set; }

    public byte? SearchOption { get; set; }

    public string? FromValue { get; set; }

    public string? ToValue { get; set; }

    public byte? AndOr { get; set; }
}
