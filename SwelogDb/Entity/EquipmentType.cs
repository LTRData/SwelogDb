using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EquipmentType
{
    public string CompanyNo { get; set; } = null!;

    public string EquipmentTypeNo { get; set; } = null!;

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? CalcWOffPercent { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual ICollection<Equipment> Equipment { get; } = new List<Equipment>();
}
