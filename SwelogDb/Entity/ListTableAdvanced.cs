using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ListTableAdvanced
{
    public int SerialNumber { get; set; }

    public string? SearchIdentifier { get; set; }

    public string? Classname { get; set; }

    public string? TableListCsv { get; set; }

    public string? TableRelations { get; set; }

    public string? ColumnListDssv { get; set; }

    public string? ColumnListAsDssv { get; set; }

    public string? ColumnsToReturnDssv { get; set; }

    public string? ReplaceJoinClause { get; set; }
}
