using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CountryGroupCode
{
    public string CountryGroupCode1 { get; set; } = null!;

    public string? Description { get; set; }

    public int? DescriptionTxtid { get; set; }

    public string? DescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }
}
