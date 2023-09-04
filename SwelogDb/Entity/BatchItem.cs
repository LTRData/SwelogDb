using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BatchItem
{
    public string ItemNumber { get; set; } = null!;

    public string RevisionNumber { get; set; } = null!;

    public virtual ICollection<BatchComponent> BatchComponents { get; } = new List<BatchComponent>();

    public virtual ICollection<BatchItemProperty> BatchItemProperties { get; } = new List<BatchItemProperty>();
}
