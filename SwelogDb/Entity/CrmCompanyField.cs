using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmCompanyField
{
    public string FieldName { get; set; } = null!;

    public string? FieldDescription { get; set; }

    public string? TemplateFieldName { get; set; }
}
