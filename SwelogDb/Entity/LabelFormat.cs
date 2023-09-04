using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LabelFormat
{
    public int SlNo { get; set; }

    public int? Across { get; set; }

    public int? Down { get; set; }

    public int? RowSpace { get; set; }

    public int? ColumnSpace { get; set; }

    public int? Height { get; set; }

    public int? Width { get; set; }

    public int? TopMargin { get; set; }

    public int? BottomMargin { get; set; }

    public int? LeftMargin { get; set; }

    public int? RightMargin { get; set; }
}
