using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmTagMaster
{
    public int SerialNumber { get; set; }

    public int TemplateSerailNumber { get; set; }

    public string? Tag { get; set; }
}
