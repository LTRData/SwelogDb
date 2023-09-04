using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductGroupTransfer
{
    public string StatusFlag { get; set; } = null!;

    public DateTime? WriteDate { get; set; }

    public DateTime? ReadDate { get; set; }

    public string ProductGroupCode { get; set; } = null!;

    public string? ParentCode { get; set; }

    public string? ProductGroupDescription { get; set; }
}
