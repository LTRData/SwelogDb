using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemInspControlTextDtl
{
    public int SerialNumber { get; set; }

    public string PartNumber { get; set; } = null!;

    public int OperationNumber { get; set; }

    public string ProjectItemNumber { get; set; } = null!;

    public string RevisionNo { get; set; } = null!;

    public virtual ItemInspControlText SerialNumberNavigation { get; set; } = null!;
}
