using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BatchComponent
{
    public string ItemNumber { get; set; } = null!;

    public string RevisionNumber { get; set; } = null!;

    public string ComponentItemNumber { get; set; } = null!;

    public string ComponentRevisionNumber { get; set; } = null!;

    public virtual BatchItem BatchItem { get; set; } = null!;
}
