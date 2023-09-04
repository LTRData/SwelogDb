using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PostalFormat
{
    public int RecNo { get; set; }

    public string? Num { get; set; }

    public string? Place { get; set; }

    public string? StateCode { get; set; }

    public string? StateName { get; set; }

    public string? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public string? ArCode { get; set; }

    public string? AuditStamp { get; set; }
}
