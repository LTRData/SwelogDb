using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UserGrade
{
    public string SupplierId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public decimal? OwnGrade { get; set; }

    public string? AuditStamp { get; set; }
}
