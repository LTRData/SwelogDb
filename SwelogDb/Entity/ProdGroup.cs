using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProdGroup
{
    public string CompanyNo { get; set; } = null!;

    public string ProductGroupNo { get; set; } = null!;

    public string ProductNo { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual Product Product { get; set; } = null!;
}
