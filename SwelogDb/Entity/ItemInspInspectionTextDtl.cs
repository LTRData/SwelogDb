using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemInspInspectionTextDtl
{
    public int SerialNumber { get; set; }

    public string PartNumber { get; set; } = null!;

    public int OperationNumber { get; set; }

    public string ProjectItemNumber { get; set; } = null!;

    public string RevisionNo { get; set; } = null!;

    public virtual ItemInspInspectionText SerialNumberNavigation { get; set; } = null!;
}
