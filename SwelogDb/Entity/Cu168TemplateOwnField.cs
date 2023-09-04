using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168TemplateOwnField
{
    public int SerialNumber { get; set; }

    public int? SerialNumberBase { get; set; }

    public string? OwnFieldName { get; set; }

    public string? OwnFieldTag { get; set; }
}
