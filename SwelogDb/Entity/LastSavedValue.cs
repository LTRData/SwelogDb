using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LastSavedValue
{
    public string Userid { get; set; } = null!;

    public string Classname { get; set; } = null!;

    public string Fieldname { get; set; } = null!;

    public int? LastSavedNumeric { get; set; }

    public string? LastSavedString { get; set; }

    public DateTime? LastSavedDatetime { get; set; }

    public string? AuditStamp { get; set; }
}
