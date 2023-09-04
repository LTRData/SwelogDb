using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GeneralInfoField
{
    public int FieldId { get; set; }

    public string? FieldName { get; set; }

    public int? ColumnOrder { get; set; }

    public string? AuditStamp { get; set; }
}
