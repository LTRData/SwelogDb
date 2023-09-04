using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeLog
{
    public int IdChangeLog { get; set; }

    public string? TableName { get; set; }

    public DateTime? LogDate { get; set; }

    public string? LogUser { get; set; }

    public string? PrimaryKey { get; set; }

    public string? PrimaryKeyValue { get; set; }

    public string? PrimarySearchKey { get; set; }

    public string? SecondaryKey { get; set; }

    public string? SecondaryKeyValue { get; set; }

    public string? FieldName { get; set; }

    public string? Operation { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? Reason { get; set; }

    public string? OldValueDetails { get; set; }

    public string? NewValueDetails { get; set; }

    public bool? SetLastChangedDate { get; set; }
}
