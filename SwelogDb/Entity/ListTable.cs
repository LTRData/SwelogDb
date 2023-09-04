using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ListTable
{
    public string UserId { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string? SelectedCols { get; set; }

    public string? SortCols { get; set; }

    public string? SelectCriteria { get; set; }

    public byte? TabNo { get; set; }
}
