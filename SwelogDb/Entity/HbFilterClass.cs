using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class HbFilterClass
{
    public string ClassId { get; set; } = null!;

    public string? ClassDescription { get; set; }

    public string Prefix { get; set; } = null!;

    public string? ValidMaterialCodes { get; set; }

    public string? AuditStamp { get; set; }

    public bool? ShowInConfigurator { get; set; }
}
