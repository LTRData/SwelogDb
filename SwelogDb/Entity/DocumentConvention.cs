using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentConvention
{
    public int SerialNumber { get; set; }

    public string? PrimaryObjectName { get; set; }

    public string? FieldList { get; set; }

    public string? SubfolderField { get; set; }
}
