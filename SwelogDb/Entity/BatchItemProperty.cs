using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BatchItemProperty
{
    public string ItemNumber { get; set; } = null!;

    public string RevisionNumber { get; set; } = null!;

    public string ComponentItemNumber { get; set; } = null!;

    public string ComponentRevisionNumber { get; set; } = null!;

    public short? SortOrder { get; set; }

    public decimal? LotQuantity { get; set; }

    public virtual BatchItem BatchItem { get; set; } = null!;
}
